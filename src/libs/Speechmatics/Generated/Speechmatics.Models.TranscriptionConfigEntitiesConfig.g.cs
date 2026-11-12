
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Configuration for Advanced Entities Detection.
    /// </summary>
    public sealed partial class TranscriptionConfigEntitiesConfig
    {
        /// <summary>
        /// Must be set together with `enable_entities: true`. When true, advanced entity detection is used instead of the default entity detection: entities such as names, dates of birth and credit card numbers are returned, each with its specific `entity_class` (e.g. 'name_given', 'dob'). When false or omitted, `enable_entities` uses the default entity detection, with entity classes such as `cardinal`, `decimal`, `fraction`, `ordinal`, `percentage`, `span` and `measurement`. Spoken and written forms are not available with advanced entity detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_advanced_entities")]
        public bool? DetectAdvancedEntities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigEntitiesConfig" /> class.
        /// </summary>
        /// <param name="detectAdvancedEntities">
        /// Must be set together with `enable_entities: true`. When true, advanced entity detection is used instead of the default entity detection: entities such as names, dates of birth and credit card numbers are returned, each with its specific `entity_class` (e.g. 'name_given', 'dob'). When false or omitted, `enable_entities` uses the default entity detection, with entity classes such as `cardinal`, `decimal`, `fraction`, `ordinal`, `percentage`, `span` and `measurement`. Spoken and written forms are not available with advanced entity detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigEntitiesConfig(
            bool? detectAdvancedEntities)
        {
            this.DetectAdvancedEntities = detectAdvancedEntities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigEntitiesConfig" /> class.
        /// </summary>
        public TranscriptionConfigEntitiesConfig()
        {
        }

    }
}