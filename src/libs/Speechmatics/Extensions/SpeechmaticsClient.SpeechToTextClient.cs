#nullable enable

using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Speechmatics;

public partial class SpeechmaticsClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("speechmatics", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        _ = audioSpeechStream ?? throw new ArgumentNullException(nameof(audioSpeechStream));

        // Build transcription config JSON
        var language = options?.SpeechLanguage is { Length: > 0 } lang ? lang : "en";
        var configJson = $"{{\"type\":\"transcription\",\"transcription_config\":{{\"language\":\"{language}\"}}}}";

        // Read audio into byte array for the generated API
        using var ms = new MemoryStream();
        await audioSpeechStream.CopyToAsync(ms, cancellationToken).ConfigureAwait(false);
        var audioBytes = ms.ToArray();

        // Submit job
        var createResponse = await CreateJobsAsync(
            config: configJson,
            dataFile: audioBytes,
            dataFilename: "audio.mp3",
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var jobId = createResponse.Id;

        // Poll until job completes
        JobDetails job;
        do
        {
            await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken).ConfigureAwait(false);
            var jobResponse = await GetJobsByJobidAsync(
                jobid: jobId,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            job = jobResponse.Job;
        }
        while (job.Status == JobDetailsStatus.Running);

        if (job.Status != JobDetailsStatus.Done)
        {
            var errorMsg = job.Errors is { Count: > 0 }
                ? string.Join("; ", job.Errors.Select(e => e.Message ?? "unknown"))
                : job.Status.ToValueString();
            throw new InvalidOperationException(
                $"Speechmatics transcription job {jobId} failed: {errorMsg}");
        }

        // Get transcript
        var transcript = await GetJobsByJobidTranscriptAsync(
            jobid: jobId,
            format: GetJobsTranscriptFormat.JsonV2,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        // Build full text from recognition results
        var textBuilder = new StringBuilder();
        if (transcript.Results is { Count: > 0 })
        {
            foreach (var result in transcript.Results)
            {
                if (result.Alternatives is { Count: > 0 })
                {
                    var best = result.Alternatives[0];
                    if (result.Type == RecognitionResultType.Punctuation)
                    {
                        textBuilder.Append(best.Content);
                    }
                    else
                    {
                        if (textBuilder.Length > 0)
                            textBuilder.Append(' ');
                        textBuilder.Append(best.Content);
                    }
                }
            }
        }

        TimeSpan? endTime = job.Duration > 0
            ? TimeSpan.FromSeconds(job.Duration.Value)
            : null;

        return new SpeechToTextResponse(textBuilder.ToString().Trim())
        {
            RawRepresentation = transcript,
            ResponseId = jobId,
            StartTime = TimeSpan.Zero,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        // Speechmatics batch API doesn't have streaming REST — use non-streaming path
        var response = await ((ISpeechToTextClient)this).GetTextAsync(
            audioSpeechStream, options, cancellationToken).ConfigureAwait(false);

        yield return new SpeechToTextResponseUpdate
        {
            Kind = SpeechToTextResponseUpdateKind.SessionOpen,
            ResponseId = response.ResponseId,
        };

        yield return new SpeechToTextResponseUpdate(response.Text)
        {
            Kind = SpeechToTextResponseUpdateKind.TextUpdated,
            ResponseId = response.ResponseId,
            StartTime = response.StartTime,
            EndTime = response.EndTime,
            RawRepresentation = response.RawRepresentation,
        };

        yield return new SpeechToTextResponseUpdate
        {
            Kind = SpeechToTextResponseUpdateKind.SessionClose,
            ResponseId = response.ResponseId,
        };
    }

    /// <summary>
    /// Converts the ApiKeyInHeader auth to Bearer auth.
    /// The generated constructor uses ApiKeyInHeader, but Speechmatics expects Bearer token.
    /// </summary>
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}
