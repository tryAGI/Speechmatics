
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Configuration for Entity Detection.
    /// </summary>
    public sealed partial class TranscriptionConfigEntitiesConfig
    {
        /// <summary>
        /// Must be set together with `enable_entities: true`. When true, Entity Detection is used instead of smart formatting entities: entities such as names, dates of birth and credit card numbers are returned, each with its specific `entity_class` (e.g. 'name_given', 'dob'). When false or omitted, `enable_entities` returns smart formatting entities, with entity classes such as `cardinal`, `decimal`, `fraction`, `ordinal`, `percentage`, `span` and `measurement` (Standard and Enhanced models only). Spoken and written forms are not available with Entity Detection.
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
        /// Must be set together with `enable_entities: true`. When true, Entity Detection is used instead of smart formatting entities: entities such as names, dates of birth and credit card numbers are returned, each with its specific `entity_class` (e.g. 'name_given', 'dob'). When false or omitted, `enable_entities` returns smart formatting entities, with entity classes such as `cardinal`, `decimal`, `fraction`, `ordinal`, `percentage`, `span` and `measurement` (Standard and Enhanced models only). Spoken and written forms are not available with Entity Detection.
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