/* order: 20, title: Speech To Text, slug: speech-to-text */

using Microsoft.Extensions.AI;

namespace Speechmatics.IntegrationTests.Examples;

[TestClass]
public class SpeechToText
{
    //// Use the MEAI `ISpeechToTextClient` interface to transcribe audio.
    //// This provides a unified API across different speech-to-text providers.

    [TestMethod]
    public async Task TranscribeWithMeai()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SPEECHMATICS_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SPEECHMATICS_API_KEY environment variable is not found.");

        //// Create a Speechmatics client that implements ISpeechToTextClient.
        using var client = new SpeechmaticsClient(apiKey);
        ISpeechToTextClient sttClient = client;

        //// Verify the client provides proper metadata.
        var metadata = sttClient.GetService<SpeechToTextClientMetadata>();
        Assert.IsNotNull(metadata);
        Assert.AreEqual("speechmatics", metadata.ProviderName);

        //// The client can also be retrieved via GetService.
        var self = sttClient.GetService<SpeechmaticsClient>();
        Assert.IsNotNull(self);
    }
}
