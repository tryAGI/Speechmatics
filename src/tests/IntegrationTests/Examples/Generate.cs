/* order: 10, title: Transcription, slug: transcription */

namespace Speechmatics.IntegrationTests.Examples;

[TestClass]
public class Transcription
{
    //// Submit an audio file for batch transcription and poll for the result.

    [TestMethod]
    public async Task TranscribeAudio()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SPEECHMATICS_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SPEECHMATICS_API_KEY environment variable is not found.");

        using var client = new SpeechmaticsClient(apiKey);

        //// Create a transcription job with a URL-based audio source.
        var configJson = """
            {
                "type": "transcription",
                "transcription_config": {
                    "language": "en"
                },
                "fetch_data": {
                    "url": "https://github.com/tryAGI/Speechmatics/raw/main/assets/test.mp3"
                }
            }
            """;
        var createResponse = await client.CreateJobsAsync(config: configJson);

        Assert.IsNotNull(createResponse.Id);

        //// Poll for job completion.
        JobDetails job;
        do
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            var jobResponse = await client.GetJobsByJobidAsync(jobid: createResponse.Id);
            job = jobResponse.Job;
        }
        while (job.Status == JobDetailsStatus.Running);

        Assert.AreEqual(JobDetailsStatus.Done, job.Status);

        //// Retrieve the transcript.
        var transcript = await client.GetJobsByJobidTranscriptAsync(
            jobid: createResponse.Id,
            format: GetJobsTranscriptFormat.JsonV2);

        Assert.IsNotNull(transcript.Results);
        Assert.IsTrue(transcript.Results.Count > 0);
    }
}
