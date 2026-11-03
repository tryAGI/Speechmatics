#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Get usage statistics
        /// </summary>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        /// <remarks>
        /// API_KEY="YOUR_API_KEY"<br/>
        /// curl -L -X GET "https://eu1.asr.api.speechmatics.com/v2/usage?since=2026-10-01&amp;until=2026-10-31" \<br/>
        ///   -H "Authorization: Bearer ${API_KEY}"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Speechmatics.UsageResponse> GetUsageAsync(
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage statistics
        /// </summary>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        /// <remarks>
        /// API_KEY="YOUR_API_KEY"<br/>
        /// curl -L -X GET "https://eu1.asr.api.speechmatics.com/v2/usage?since=2026-10-01&amp;until=2026-10-31" \<br/>
        ///   -H "Authorization: Bearer ${API_KEY}"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Speechmatics.AutoSDKHttpResponse<global::Speechmatics.UsageResponse>> GetUsageAsResponseAsync(
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::Speechmatics.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}