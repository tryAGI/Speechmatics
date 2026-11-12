
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// The transcript as a JSON object (the Speechmatics JSON v2 transcript — see RetrieveTranscriptResponse), returned verbatim from the stored transcript. Best-effort: present when `status` is `done` and `format` was `json-v2` (the default) and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
    /// </summary>
    public sealed partial class CreateJobResponseJsonV2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}