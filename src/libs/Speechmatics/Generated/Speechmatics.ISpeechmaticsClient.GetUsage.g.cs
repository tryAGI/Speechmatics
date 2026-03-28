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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.UsageResponse> GetUsageAsync(
            global::System.DateTime? since = default,
            global::System.DateTime? until = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}