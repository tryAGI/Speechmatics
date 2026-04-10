#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Get object URLs<br/>
        /// Get signed urls for data files associated to the job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="ttl"></param>
        /// <param name="urlFor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.RetrieveObjectUrlsResponse> GetJobsByJobidObjectUrlsAsync(
            string jobid,
            int ttl,
            global::System.Collections.Generic.IList<global::Speechmatics.GetJobsObjectUrlsUrlForItem> urlFor,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}