
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// **Note**: Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
    /// </summary>
    public enum CreateJobResponseStatus
    {
        /// <summary>
        /// Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </summary>
        Created,
        /// <summary>
        /// Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </summary>
        Deleted,
        /// <summary>
        /// Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </summary>
        Done,
        /// <summary>
        /// Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobResponseStatus value)
        {
            return value switch
            {
                CreateJobResponseStatus.Created => "created",
                CreateJobResponseStatus.Deleted => "deleted",
                CreateJobResponseStatus.Done => "done",
                CreateJobResponseStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateJobResponseStatus.Created,
                "deleted" => CreateJobResponseStatus.Deleted,
                "done" => CreateJobResponseStatus.Done,
                "rejected" => CreateJobResponseStatus.Rejected,
                _ => null,
            };
        }
    }
}