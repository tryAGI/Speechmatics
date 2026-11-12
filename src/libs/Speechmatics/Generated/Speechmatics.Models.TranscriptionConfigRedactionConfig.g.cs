
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Configuration for redaction. Required, and only applied, when `enable_redaction` is true.
    /// </summary>
    public sealed partial class TranscriptionConfigRedactionConfig
    {
        /// <summary>
        /// Categories of advanced entities to redact. Each value is either a group or a specific entity type, and groups and entity types can be mixed. Groups: `pii`, `pci` and `health` (personal, payment card and health information), and the regulation-based groups `gdpr`, `gdpr_sensitive`, `hipaa_safe_harbor`, `cpra`, `quebec_privacy_act`, `appi` and `appi_sensitive`. Specific entity types are matched by their `entity_class` (e.g. `name_given`, `dob`, `credit_card`); a general type such as `name` or `location` also covers its more specific types (e.g. `name_given`, `location_city`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_classes")]
        public global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigRedactionConfigEntityClasse>? EntityClasses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigRedactionConfig" /> class.
        /// </summary>
        /// <param name="entityClasses">
        /// Categories of advanced entities to redact. Each value is either a group or a specific entity type, and groups and entity types can be mixed. Groups: `pii`, `pci` and `health` (personal, payment card and health information), and the regulation-based groups `gdpr`, `gdpr_sensitive`, `hipaa_safe_harbor`, `cpra`, `quebec_privacy_act`, `appi` and `appi_sensitive`. Specific entity types are matched by their `entity_class` (e.g. `name_given`, `dob`, `credit_card`); a general type such as `name` or `location` also covers its more specific types (e.g. `name_given`, `location_city`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigRedactionConfig(
            global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigRedactionConfigEntityClasse>? entityClasses)
        {
            this.EntityClasses = entityClasses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigRedactionConfig" /> class.
        /// </summary>
        public TranscriptionConfigRedactionConfig()
        {
        }

    }
}