#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="wait"></param>
        /// <param name="format"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        /// <remarks>
        /// import { openAsBlob } from "node:fs";<br/>
        /// import { BatchClient } from "@speechmatics/batch-client";<br/>
        /// const client = new BatchClient({ apiKey: "YOUR_API_KEY", appId: "my-app" });<br/>
        /// // In a browser, pass a File from a file input instead.<br/>
        /// const file = new File([await openAsBlob("example.wav")], "example.wav");<br/>
        /// const { id } = await client.createTranscriptionJob(file, {<br/>
        ///   transcription_config: { language: "en", model: "enhanced" },<br/>
        /// });<br/>
        /// console.log(id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Speechmatics.CreateJobResponse> CreateJobsAsync(

            global::Speechmatics.CreateJobsRequest request,
            string? xSmProcessingData = default,
            int? wait = default,
            global::Speechmatics.CreateJobsFormat? format = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="wait"></param>
        /// <param name="format"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        /// <remarks>
        /// import { openAsBlob } from "node:fs";<br/>
        /// import { BatchClient } from "@speechmatics/batch-client";<br/>
        /// const client = new BatchClient({ apiKey: "YOUR_API_KEY", appId: "my-app" });<br/>
        /// // In a browser, pass a File from a file input instead.<br/>
        /// const file = new File([await openAsBlob("example.wav")], "example.wav");<br/>
        /// const { id } = await client.createTranscriptionJob(file, {<br/>
        ///   transcription_config: { language: "en", model: "enhanced" },<br/>
        /// });<br/>
        /// console.log(id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Speechmatics.AutoSDKHttpResponse<global::Speechmatics.CreateJobResponse>> CreateJobsAsResponseAsync(

            global::Speechmatics.CreateJobsRequest request,
            string? xSmProcessingData = default,
            int? wait = default,
            global::Speechmatics.CreateJobsFormat? format = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new job
        /// </summary>
        /// <param name="xSmProcessingData"></param>
        /// <param name="wait"></param>
        /// <param name="format"></param>
        /// <param name="config">
        /// JSON containing a `JobConfig` model indicating the type and parameters for the recognition job.
        /// </param>
        /// <param name="dataFile">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="dataFilename">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.CreateJobResponse> CreateJobsAsync(
            string config,
            string? xSmProcessingData = default,
            int? wait = default,
            global::Speechmatics.CreateJobsFormat? format = default,
            byte[]? dataFile = default,
            string? dataFilename = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}