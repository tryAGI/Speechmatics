
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.SummarizationErrorTypeJsonConverter))]
        public global::Speechmatics.SummarizationErrorType? Type { get; set; }

        /// <summary>
        /// Human readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Human readable error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationError(
            global::Speechmatics.SummarizationErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationError" /> class.
        /// </summary>
        public SummarizationError()
        {
        }
    }
}