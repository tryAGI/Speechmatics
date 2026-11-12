
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Properties of the language pack.
    /// </summary>
    public sealed partial class LanguagePackInfo
    {
        /// <summary>
        /// Mapping from language codes to their word delimiters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_language_word_delimiters")]
        public global::System.Collections.Generic.Dictionary<string, string>? PerLanguageWordDelimiters { get; set; }

        /// <summary>
        /// Mapping from languages codes to their writing direction, left-to-right or right-to-left
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_language_writing_direction")]
        public global::System.Collections.Generic.Dictionary<string, global::Speechmatics.LanguagePackInfoPerLanguageWritingDirection2>? PerLanguageWritingDirection { get; set; }

        /// <summary>
        /// Full descriptive name of the language, e.g. 'Japanese'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_description")]
        public string? LanguageDescription { get; set; }

        /// <summary>
        /// The character to use to separate words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_delimiter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WordDelimiter { get; set; }

        /// <summary>
        /// The direction that words in the language should be written and read in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writing_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.LanguagePackInfoWritingDirectionJsonConverter))]
        public global::Speechmatics.LanguagePackInfoWritingDirection? WritingDirection { get; set; }

        /// <summary>
        /// Whether or not ITN (inverse text normalization) is available for the language pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itn")]
        public bool? Itn { get; set; }

        /// <summary>
        /// Whether or not language model adaptation has been applied to the language pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapted")]
        public bool? Adapted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePackInfo" /> class.
        /// </summary>
        /// <param name="wordDelimiter">
        /// The character to use to separate words.
        /// </param>
        /// <param name="perLanguageWordDelimiters">
        /// Mapping from language codes to their word delimiters
        /// </param>
        /// <param name="perLanguageWritingDirection">
        /// Mapping from languages codes to their writing direction, left-to-right or right-to-left
        /// </param>
        /// <param name="languageDescription">
        /// Full descriptive name of the language, e.g. 'Japanese'.
        /// </param>
        /// <param name="writingDirection">
        /// The direction that words in the language should be written and read in.
        /// </param>
        /// <param name="itn">
        /// Whether or not ITN (inverse text normalization) is available for the language pack.
        /// </param>
        /// <param name="adapted">
        /// Whether or not language model adaptation has been applied to the language pack.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguagePackInfo(
            string wordDelimiter,
            global::System.Collections.Generic.Dictionary<string, string>? perLanguageWordDelimiters,
            global::System.Collections.Generic.Dictionary<string, global::Speechmatics.LanguagePackInfoPerLanguageWritingDirection2>? perLanguageWritingDirection,
            string? languageDescription,
            global::Speechmatics.LanguagePackInfoWritingDirection? writingDirection,
            bool? itn,
            bool? adapted)
        {
            this.PerLanguageWordDelimiters = perLanguageWordDelimiters;
            this.PerLanguageWritingDirection = perLanguageWritingDirection;
            this.LanguageDescription = languageDescription;
            this.WordDelimiter = wordDelimiter ?? throw new global::System.ArgumentNullException(nameof(wordDelimiter));
            this.WritingDirection = writingDirection;
            this.Itn = itn;
            this.Adapted = adapted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePackInfo" /> class.
        /// </summary>
        public LanguagePackInfo()
        {
        }

    }
}