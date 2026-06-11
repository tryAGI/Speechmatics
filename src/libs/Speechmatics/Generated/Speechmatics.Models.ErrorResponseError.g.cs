
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// The error message.
    /// </summary>
    public enum ErrorResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        BadRequest,
        /// <summary>
        /// 
        /// </summary>
        FileExpired,
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        FormatNotSupported,
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        JobExpired,
        /// <summary>
        /// 
        /// </summary>
        JobInProgress,
        /// <summary>
        /// 
        /// </summary>
        JobError,
        /// <summary>
        /// 
        /// </summary>
        JobIsNotOfTypeTranscription,
        /// <summary>
        /// 
        /// </summary>
        JobNotFound,
        /// <summary>
        /// 
        /// </summary>
        JobRejected,
        /// <summary>
        /// 
        /// </summary>
        JobRejectedDueToInvalidAudio,
        /// <summary>
        /// 
        /// </summary>
        JobRejectedDueToInvalidText,
        /// <summary>
        /// 
        /// </summary>
        LogFileNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        MalformedRequest,
        /// <summary>
        /// 
        /// </summary>
        MaxConcurrentRunningJobsExceeded,
        /// <summary>
        /// 
        /// </summary>
        MissingCallback,
        /// <summary>
        /// 
        /// </summary>
        MissingDataFile,
        /// <summary>
        /// 
        /// </summary>
        NoLanguageSelected,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        RequestedProductNotAvailable,
        /// <summary>
        /// 
        /// </summary>
        ResourceLocked,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionNotReady,
        /// <summary>
        /// 
        /// </summary>
        UnprocessableEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorResponseErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseError value)
        {
            return value switch
            {
                ErrorResponseError.BadRequest => "Bad Request",
                ErrorResponseError.FileExpired => "File Expired",
                ErrorResponseError.Forbidden => "Forbidden",
                ErrorResponseError.FormatNotSupported => "Format Not Supported",
                ErrorResponseError.InternalServerError => "Internal Server Error",
                ErrorResponseError.JobExpired => "Job Expired",
                ErrorResponseError.JobInProgress => "Job In Progress",
                ErrorResponseError.JobError => "Job error",
                ErrorResponseError.JobIsNotOfTypeTranscription => "Job is not of type transcription",
                ErrorResponseError.JobNotFound => "Job not found",
                ErrorResponseError.JobRejected => "Job rejected",
                ErrorResponseError.JobRejectedDueToInvalidAudio => "Job rejected due to invalid audio",
                ErrorResponseError.JobRejectedDueToInvalidText => "Job rejected due to invalid text",
                ErrorResponseError.LogFileNotAvailable => "Log file not available",
                ErrorResponseError.MalformedRequest => "Malformed request",
                ErrorResponseError.MaxConcurrentRunningJobsExceeded => "Max concurrent running jobs exceeded",
                ErrorResponseError.MissingCallback => "Missing callback",
                ErrorResponseError.MissingDataFile => "Missing data_file",
                ErrorResponseError.NoLanguageSelected => "No language selected",
                ErrorResponseError.NotImplemented => "Not Implemented",
                ErrorResponseError.PermissionDenied => "Permission Denied",
                ErrorResponseError.RequestedProductNotAvailable => "Requested product not available",
                ErrorResponseError.ResourceLocked => "Resource Locked",
                ErrorResponseError.TranscriptionNotReady => "Transcription not ready",
                ErrorResponseError.UnprocessableEntity => "Unprocessable Entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseError? ToEnum(string value)
        {
            return value switch
            {
                "Bad Request" => ErrorResponseError.BadRequest,
                "File Expired" => ErrorResponseError.FileExpired,
                "Forbidden" => ErrorResponseError.Forbidden,
                "Format Not Supported" => ErrorResponseError.FormatNotSupported,
                "Internal Server Error" => ErrorResponseError.InternalServerError,
                "Job Expired" => ErrorResponseError.JobExpired,
                "Job In Progress" => ErrorResponseError.JobInProgress,
                "Job error" => ErrorResponseError.JobError,
                "Job is not of type transcription" => ErrorResponseError.JobIsNotOfTypeTranscription,
                "Job not found" => ErrorResponseError.JobNotFound,
                "Job rejected" => ErrorResponseError.JobRejected,
                "Job rejected due to invalid audio" => ErrorResponseError.JobRejectedDueToInvalidAudio,
                "Job rejected due to invalid text" => ErrorResponseError.JobRejectedDueToInvalidText,
                "Log file not available" => ErrorResponseError.LogFileNotAvailable,
                "Malformed request" => ErrorResponseError.MalformedRequest,
                "Max concurrent running jobs exceeded" => ErrorResponseError.MaxConcurrentRunningJobsExceeded,
                "Missing callback" => ErrorResponseError.MissingCallback,
                "Missing data_file" => ErrorResponseError.MissingDataFile,
                "No language selected" => ErrorResponseError.NoLanguageSelected,
                "Not Implemented" => ErrorResponseError.NotImplemented,
                "Permission Denied" => ErrorResponseError.PermissionDenied,
                "Requested product not available" => ErrorResponseError.RequestedProductNotAvailable,
                "Resource Locked" => ErrorResponseError.ResourceLocked,
                "Transcription not ready" => ErrorResponseError.TranscriptionNotReady,
                "Unprocessable Entity" => ErrorResponseError.UnprocessableEntity,
                _ => null,
            };
        }
    }
}