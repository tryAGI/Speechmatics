
#nullable enable

namespace Speechmatics
{
    /// <summary>
    ///
    /// </summary>
    public enum LanguagePackInfoPerLanguageWritingDirection2
    {
        /// <summary>
        ///
        /// </summary>
        LeftToRight,
        /// <summary>
        ///
        /// </summary>
        RightToLeft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguagePackInfoPerLanguageWritingDirection2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguagePackInfoPerLanguageWritingDirection2 value)
        {
            return value switch
            {
                LanguagePackInfoPerLanguageWritingDirection2.LeftToRight => "left-to-right",
                LanguagePackInfoPerLanguageWritingDirection2.RightToLeft => "right-to-left",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguagePackInfoPerLanguageWritingDirection2? ToEnum(string value)
        {
            return value switch
            {
                "left-to-right" => LanguagePackInfoPerLanguageWritingDirection2.LeftToRight,
                "right-to-left" => LanguagePackInfoPerLanguageWritingDirection2.RightToLeft,
                _ => null,
            };
        }
    }
}