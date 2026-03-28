/* order: 30, title: MEAI Tools, slug: meai-tools */

namespace Speechmatics.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Speechmatics provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SPEECHMATICS_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SPEECHMATICS_API_KEY environment variable is not found.");

        using var client = new SpeechmaticsClient(apiKey);

        //// Create tools for transcription, job status, and job listing.
        var transcribeTool = client.AsTranscribeUrlTool(defaultLanguage: "en");
        var getJobStatusTool = client.AsGetJobStatusTool();
        var listJobsTool = client.AsListJobsTool(defaultLimit: 5);

        Assert.AreEqual("Speechmatics_TranscribeUrl", transcribeTool.Name);
        Assert.AreEqual("Speechmatics_GetJobStatus", getJobStatusTool.Name);
        Assert.AreEqual("Speechmatics_ListJobs", listJobsTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { transcribeTool, getJobStatusTool, listJobsTool };
        Assert.AreEqual(3, tools.Length);
    }
}
