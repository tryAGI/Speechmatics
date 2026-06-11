
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// A confidence score in the range of 0-1,<br/>
    /// indicating the model's certainty in the predicted sentiment,
    /// </summary>
    public sealed partial class SentimentSegmentConfidence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}