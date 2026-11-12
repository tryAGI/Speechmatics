
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// The outcome of the request. Only present when the `wait` query parameter was specified on the request; when `wait` is omitted the field is absent and the legacy response (just `id`) is returned. * `created` - The job record was created, but the wait elapsed before the job reached a terminal state. The job can still be polled or retrieved as usual. * `done` - The job finished. The result is embedded under the key named after the requested `format` when available; if that field is absent (e.g. the format was not produced, or the result is not yet readable), fetch it from `GET /jobs/{id}/transcript`. * `rejected` - The job was created but could not be processed. * `deleted` - Theoretical race condition handling.
    /// </summary>
    public enum CreateJobResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        Done,
        /// <summary>
        ///
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