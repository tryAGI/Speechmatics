# CLAUDE.md — Speechmatics SDK

## Overview

Auto-generated C# SDK for [Speechmatics](https://www.speechmatics.com/) — batch speech-to-text transcription with 55+ languages, speaker diarization, sentiment analysis, topic detection, summarization, translation, and chapters.
OpenAPI spec from `https://docs.speechmatics.com/batch.yaml` (Swagger 2.0, transformed for auth).

## Build & Test

```bash
dotnet build Speechmatics.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth. Constructor uses ApiKeyInHeader internally, converted to Bearer via `Authorized` partial hook:

```csharp
var client = new SpeechmaticsClient(apiKey); // SPEECHMATICS_API_KEY env var
```

## Key Files

- `src/libs/Speechmatics/openapi.yaml` — Transformed Swagger 2.0 spec
- `src/libs/Speechmatics/generate.sh` — Downloads spec, fixes auth/params, runs autosdk
- `src/libs/Speechmatics/Generated/` — **Never edit** — auto-generated code
- `src/libs/Speechmatics/Extensions/SpeechmaticsClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient`
- `src/libs/Speechmatics/Extensions/SpeechmaticsClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## API Pattern

Single client (no sub-clients) with all endpoints directly:

```csharp
client.CreateJobsAsync(config, dataFile, dataFilename, ...)  // Submit transcription
client.GetJobsByJobidAsync(jobid)                             // Get job status
client.GetJobsByJobidTranscriptAsync(jobid, format)           // Get transcript
client.GetJobsAsync(limit, createdBefore, includeDeleted)     // List jobs
client.GetJobsByJobidTextAsync(jobid)                         // Get plain text
client.DeleteJobsByJobidAsync(jobid)                          // Delete job
client.GetUsageAsync(...)                                     // Usage stats
```

## MEAI Integration

`ISpeechToTextClient` — submit batch transcription job, poll for completion, return transcript:
```csharp
ISpeechToTextClient sttClient = client;
var response = await sttClient.GetTextAsync(audioStream, options);
```

AIFunction tools for use with any `IChatClient`:
- `AsTranscribeUrlTool(defaultLanguage)` — Transcribe audio from URL (submit + poll + get transcript)
- `AsGetJobStatusTool()` — Get transcription job status and details
- `AsListJobsTool(defaultLimit)` — List recent transcription jobs

## Spec Notes

- Base URL: `https://asr.api.speechmatics.com/v2`
- Original spec: Swagger 2.0 from docs.speechmatics.com/batch.yaml
- Auth fix: Python transforms apiKey → http/bearer; `--security-scheme Http:Header:Bearer` flag
- AuthHeader/EARTag parameters removed (handled by security scheme)
- Job status: `running` → `done`/`rejected`/`deleted`/`expired`
- 55+ languages supported
