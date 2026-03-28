#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// List all jobs
        /// </summary>
        /// <param name="createdBefore"></param>
        /// <param name="limit"></param>
        /// <param name="includeDeleted"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        /// <remarks>
        /// import { BatchClient } from "@speechmatics/batch-client";<br/>
        /// const client = new BatchClient({ apiKey: "YOUR_API_KEY" });<br/>
        /// const response = await client.listJobs();<br/>
        /// const json = await response.json();<br/>
        /// console.log(json);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Speechmatics.RetrieveJobsResponse> GetJobsAsync(
            global::System.DateTime? createdBefore = default,
            int? limit = default,
            bool? includeDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}