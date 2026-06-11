
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Specific model to use in transcription (previously called operating point).
    /// </summary>
    public enum Model
    {
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Model value)
        {
            return value switch
            {
                Model.Enhanced => "enhanced",
                Model.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Model? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => Model.Enhanced,
                "standard" => Model.Standard,
                _ => null,
            };
        }
    }
}