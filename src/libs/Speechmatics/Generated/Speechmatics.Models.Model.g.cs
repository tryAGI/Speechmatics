
#nullable enable

namespace Speechmatics
{
    /// <summary>
    ///
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
        Melia1,
        /// <summary>
        ///
        /// </summary>
        Oak1,
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
                Model.Melia1 => "melia-1",
                Model.Oak1 => "oak-1",
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
                "melia-1" => Model.Melia1,
                "oak-1" => Model.Oak1,
                "standard" => Model.Standard,
                _ => null,
            };
        }
    }
}