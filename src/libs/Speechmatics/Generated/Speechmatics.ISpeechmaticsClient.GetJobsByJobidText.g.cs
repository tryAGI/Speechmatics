#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Get the text file used as input to an alignment job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidTextAsync(
            string jobid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}