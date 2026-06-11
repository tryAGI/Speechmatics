
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotificationConfigContent
    {
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Jobinfo,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        TranscriptJsonV2,
        /// <summary>
        /// 
        /// </summary>
        TranscriptSrt,
        /// <summary>
        /// 
        /// </summary>
        TranscriptTxt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationConfigContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationConfigContent value)
        {
            return value switch
            {
                NotificationConfigContent.Data => "data",
                NotificationConfigContent.Jobinfo => "jobinfo",
                NotificationConfigContent.Text => "text",
                NotificationConfigContent.Transcript => "transcript",
                NotificationConfigContent.TranscriptJsonV2 => "transcript.json-v2",
                NotificationConfigContent.TranscriptSrt => "transcript.srt",
                NotificationConfigContent.TranscriptTxt => "transcript.txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationConfigContent? ToEnum(string value)
        {
            return value switch
            {
                "data" => NotificationConfigContent.Data,
                "jobinfo" => NotificationConfigContent.Jobinfo,
                "text" => NotificationConfigContent.Text,
                "transcript" => NotificationConfigContent.Transcript,
                "transcript.json-v2" => NotificationConfigContent.TranscriptJsonV2,
                "transcript.srt" => NotificationConfigContent.TranscriptSrt,
                "transcript.txt" => NotificationConfigContent.TranscriptTxt,
                _ => null,
            };
        }
    }
}