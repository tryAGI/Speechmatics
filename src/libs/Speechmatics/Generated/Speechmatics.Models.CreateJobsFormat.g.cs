
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        JsonV2,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateJobsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsFormat value)
        {
            return value switch
            {
                CreateJobsFormat.JsonV2 => "json-v2",
                CreateJobsFormat.Srt => "srt",
                CreateJobsFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsFormat? ToEnum(string value)
        {
            return value switch
            {
                "json-v2" => CreateJobsFormat.JsonV2,
                "srt" => CreateJobsFormat.Srt,
                "txt" => CreateJobsFormat.Txt,
                _ => null,
            };
        }
    }
}