
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObjectUrlForEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AudioMp3,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectUrlForEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectUrlForEnum value)
        {
            return value switch
            {
                ObjectUrlForEnum.AudioMp3 => "audio_mp3",
                ObjectUrlForEnum.Data => "data",
                ObjectUrlForEnum.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectUrlForEnum? ToEnum(string value)
        {
            return value switch
            {
                "audio_mp3" => ObjectUrlForEnum.AudioMp3,
                "data" => ObjectUrlForEnum.Data,
                "transcript" => ObjectUrlForEnum.Transcript,
                _ => null,
            };
        }
    }
}