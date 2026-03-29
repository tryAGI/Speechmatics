# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Speechmatics SDK implements `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) for batch speech-to-text transcription, plus `AIFunction` tool wrappers for use with any `IChatClient`.

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

The raw Speechmatics transcript is available via `RawRepresentation` for advanced access to recognition results, speaker diarization, and other features:

```csharp
ISpeechToTextClient sttClient = client;

using var audioStream = File.OpenRead("audio.mp3");
var response = await sttClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);

// Access full Speechmatics transcript for recognition-level detail
var raw = (TranscriptResponse)response.RawRepresentation!;
Console.WriteLine($"Results: {raw.Results?.Count}");
```

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
