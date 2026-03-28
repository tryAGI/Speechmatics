#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Get job details<br/>
        /// Get job details, including progress and any error reports.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechmatics.RetrieveJobResponse> GetJobsByJobidAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}