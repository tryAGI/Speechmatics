#nullable enable

namespace Speechmatics
{
    public partial interface ISpeechmaticsClient
    {
        /// <summary>
        /// Get the aligned text file for an alignment job.
        /// </summary>
        /// <param name="jobid"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechmatics.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetJobsByJobidAlignmentAsync(
            string jobid,
            global::Speechmatics.GetJobsAlignmentTags? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}