#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Delete a job<br/>
        /// Delete a job and remove all associated resources.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="force"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.DeleteJobResponse> DeleteJobsByJobidAsync(
            string jobid,
            bool? force = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a job<br/>
        /// Delete a job and remove all associated resources.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="force"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.AutoSDKHttpResponse<global::Speechmatics.DeleteJobResponse>> DeleteJobsByJobidAsResponseAsync(
            string jobid,
            bool? force = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}