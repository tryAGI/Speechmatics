#nullable enable

using System.ComponentModel;
using System.Text;
using Microsoft.Extensions.AI;

namespace Speechmatics;

public static class SpeechmaticsClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that transcribes audio from a URL using the Speechmatics batch API.
    /// </summary>
    public static AIFunction AsTranscribeUrlTool(
        this SpeechmaticsClient client,
        string? defaultLanguage = null)
    {
        return AIFunctionFactory.Create(
            async ([Description("The URL of the audio/video file to transcribe")] string url,
                   [Description("The language code (e.g. 'en', 'fr', 'de'). Defaults to auto-detect.")] string? language,
                   CancellationToken cancellationToken) =>
            {
                var lang = language ?? defaultLanguage ?? "en";
                var configJson = $"{{\"type\":\"transcription\",\"transcription_config\":{{\"language\":\"{lang}\"}},\"fetch_data\":{{\"url\":\"{url}\"}}}}";

                var createResponse = await client.CreateJobsAsync(
                    config: configJson,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var jobId = createResponse.Id;

                // Poll until done
                JobDetails job;
                do
                {
                    await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken).ConfigureAwait(false);
                    var jobResponse = await client.GetJobsByJobidAsync(
                        jobid: jobId,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    job = jobResponse.Job;
                }
                while (job.Status == JobDetailsStatus.Running);

                if (job.Status != JobDetailsStatus.Done)
                {
                    return $"Transcription failed with status: {job.Status.ToValueString()}";
                }

                var transcript = await client.GetJobsByJobidTranscriptAsync(
                    jobid: jobId,
                    format: GetJobsTranscriptFormat.JsonV2,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var textBuilder = new StringBuilder();
                if (transcript.Results is { Count: > 0 })
                {
                    foreach (var result in transcript.Results)
                    {
                        if (result.Alternatives is { Count: > 0 })
                        {
                            var best = result.Alternatives[0];
                            if (result.Type == RecognitionResultType.Punctuation)
                                textBuilder.Append(best.Content);
                            else
                            {
                                if (textBuilder.Length > 0) textBuilder.Append(' ');
                                textBuilder.Append(best.Content);
                            }
                        }
                    }
                }

                return textBuilder.ToString().Trim();
            },
            name: "Speechmatics_TranscribeUrl",
            description: "Transcribe audio/video from a URL using Speechmatics batch speech-to-text (55+ languages, speaker diarization).");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a transcription job.
    /// </summary>
    public static AIFunction AsGetJobStatusTool(this SpeechmaticsClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The job ID to check status for")] string jobId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetJobsByJobidAsync(
                    jobid: jobId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var job = response.Job;
                return new
                {
                    job.Id,
                    Status = job.Status.ToValueString(),
                    job.DataName,
                    job.Duration,
                    job.CreatedAt,
                };
            },
            name: "Speechmatics_GetJobStatus",
            description: "Get the status and details of a Speechmatics transcription job.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists recent transcription jobs.
    /// </summary>
    public static AIFunction AsListJobsTool(
        this SpeechmaticsClient client,
        int defaultLimit = 10)
    {
        return AIFunctionFactory.Create(
            async ([Description("Maximum number of jobs to return")] int? limit,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.GetJobsAsync(
                    limit: limit ?? defaultLimit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Speechmatics_ListJobs",
            description: "List recent Speechmatics transcription jobs with their status and details.");
    }
}
