# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Speechmatics SDK implements `ISpeechToTextClient` and provides `AIFunction` tool wrappers, all compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Installation

```bash
dotnet add package tryAGI.Speechmatics
```

## ISpeechToTextClient

The `SpeechmaticsClient` implements `ISpeechToTextClient` for batch speech-to-text transcription.
It uploads audio, submits a transcription job, and polls until completion. Supports 55+ languages.

### File-Based Transcription

Transcribe an audio file to text. The client uploads the audio via multipart form data, creates a batch job, and polls until the transcript is ready:

```csharp
using Microsoft.Extensions.AI;
using Speechmatics;

using var client = new SpeechmaticsClient(
    apiKey: Environment.GetEnvironmentVariable("SPEECHMATICS_API_KEY")!);
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.mp3");
var response = await sttClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
Console.WriteLine($"Duration: {response.StartTime} - {response.EndTime}");
```

### Transcription with Language Hint

Specify a language code for more accurate transcription (default is `"en"`):

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("french-audio.mp3");
var response = await sttClient.GetTextAsync(audioStream, new SpeechToTextOptions
{
    SpeechLanguage = "fr",
});

Console.WriteLine(response.Text);
```

### Accessing the Raw Transcript

The raw Speechmatics transcript is available via `RawRepresentation` for advanced access to recognition results, speaker diarization, timestamps, and other provider-specific features:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.mp3");
var response = await sttClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);

// Access full Speechmatics transcript for recognition-level detail
var raw = (TranscriptResponse)response.RawRepresentation!;
Console.WriteLine($"Format: {raw.Format}");
Console.WriteLine($"Results: {raw.Results?.Count}");

// Iterate individual recognition results for word-level timestamps and confidence
if (raw.Results is { Count: > 0 })
{
    foreach (var result in raw.Results)
    {
        if (result.Alternatives is { Count: > 0 })
        {
            var best = result.Alternatives[0];
            Console.WriteLine($"  [{result.StartTime:F2}s - {result.EndTime:F2}s] " +
                $"{best.Content} (confidence: {best.Confidence:P0}, speaker: {best.Speaker})");
        }
    }
}
```

### Advanced Configuration with RawRepresentationFactory

The Speechmatics batch API supports advanced features like diarization, summarization, translation, and custom vocabulary through the transcription config JSON. While the standard MEAI interface handles basic transcription, you can use `RawRepresentationFactory` to configure these features when submitting jobs directly via the client:

```csharp
// For advanced configuration, use the SpeechmaticsClient directly
var speechmaticsClient = sttClient.GetService<SpeechmaticsClient>()!;

// Submit a job with diarization, summarization, and custom vocabulary
var configJson = """
{
    "type": "transcription",
    "transcription_config": {
        "language": "en",
        "diarization": "speaker",
        "additional_vocab": [
            { "content": "Speechmatics", "sounds_like": ["speech matics"] }
        ]
    },
    "summarization_config": {},
    "sentiment_analysis_config": {}
}
""";

using var audioStream = File.OpenRead("meeting.mp3");
using var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);

var job = await speechmaticsClient.CreateJobsAsync(
    config: configJson,
    dataFile: ms.ToArray(),
    dataFilename: "meeting.mp3");

Console.WriteLine($"Job submitted: {job.Id}");
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The batch transcription job (submit + poll + get transcript) runs to completion first, and then the full result is yielded as a single `TextUpdated` update bracketed by `SessionOpen` and `SessionClose` events.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after the job finishes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

!!! note
    Speechmatics does offer a real-time streaming WebSocket API, but it is not exposed through the MEAI `ISpeechToTextClient` interface. Use the `SpeechmaticsClient` directly for real-time streaming needs.

### Accessing the Underlying Client

Retrieve the `SpeechmaticsClient` from the MEAI interface:

```csharp
ISpeechToTextClient sttClient = client;

var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "speechmatics"

var speechmaticsClient = sttClient.GetService<SpeechmaticsClient>();
// Use speechmaticsClient for Speechmatics-specific APIs (usage stats, job management, etc.)
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTranscribeUrlTool()` | `Speechmatics_TranscribeUrl` | Transcribe audio/video from URL (55+ languages) |
| `AsGetJobStatusTool()` | `Speechmatics_GetJobStatus` | Get transcription job status |
| `AsListJobsTool()` | `Speechmatics_ListJobs` | List recent transcription jobs |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Speechmatics;

var client = new SpeechmaticsClient(
    apiKey: Environment.GetEnvironmentVariable("SPEECHMATICS_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsTranscribeUrlTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Transcribe the audio at https://example.com/podcast.mp3"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
