# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Speechmatics SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient`.

## Installation

```bash
dotnet add package tryAGI.Speechmatics
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
