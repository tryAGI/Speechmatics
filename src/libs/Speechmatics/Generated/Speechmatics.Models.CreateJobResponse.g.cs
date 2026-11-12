
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Example: {"id":"a1b2c3d4e5"}
    /// </summary>
    public sealed partial class CreateJobResponse
    {
        /// <summary>
        /// The unique ID assigned to the job. Keep a record of this for later retrieval of your completed job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The outcome of the request. Only present when the `wait` query parameter was specified on the request; when `wait` is omitted the field is absent and the legacy response (just `id`) is returned. * `created` - The job record was created, but the wait elapsed before the job reached a terminal state. The job can still be polled or retrieved as usual. * `done` - The job finished. The result is embedded under the key named after the requested `format` when available; if that field is absent (e.g. the format was not produced, or the result is not yet readable), fetch it from `GET /jobs/{id}/transcript`. * `rejected` - The job was created but could not be processed. * `deleted` - Theoretical race condition handling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.CreateJobResponseStatusJsonConverter))]
        public global::Speechmatics.CreateJobResponseStatus? Status { get; set; }

        /// <summary>
        /// The transcript as a JSON object (the Speechmatics JSON v2 transcript — see RetrieveTranscriptResponse), returned verbatim from the stored transcript. Best-effort: present when `status` is `done` and `format` was `json-v2` (the default) and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json-v2")]
        public object? JsonV2 { get; set; }

        /// <summary>
        /// The transcript as plain text. Best-effort: present when `status` is `done` and `format` was `txt` and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt")]
        public string? Txt { get; set; }

        /// <summary>
        /// The transcript as SubRip (SRT) subtitles. Best-effort: present when `status` is `done` and `format` was `srt` and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srt")]
        public string? Srt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID assigned to the job. Keep a record of this for later retrieval of your completed job.
        /// </param>
        /// <param name="status">
        /// The outcome of the request. Only present when the `wait` query parameter was specified on the request; when `wait` is omitted the field is absent and the legacy response (just `id`) is returned. * `created` - The job record was created, but the wait elapsed before the job reached a terminal state. The job can still be polled or retrieved as usual. * `done` - The job finished. The result is embedded under the key named after the requested `format` when available; if that field is absent (e.g. the format was not produced, or the result is not yet readable), fetch it from `GET /jobs/{id}/transcript`. * `rejected` - The job was created but could not be processed. * `deleted` - Theoretical race condition handling.
        /// </param>
        /// <param name="jsonV2">
        /// The transcript as a JSON object (the Speechmatics JSON v2 transcript — see RetrieveTranscriptResponse), returned verbatim from the stored transcript. Best-effort: present when `status` is `done` and `format` was `json-v2` (the default) and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </param>
        /// <param name="txt">
        /// The transcript as plain text. Best-effort: present when `status` is `done` and `format` was `txt` and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </param>
        /// <param name="srt">
        /// The transcript as SubRip (SRT) subtitles. Best-effort: present when `status` is `done` and `format` was `srt` and the result is readable; if absent, fetch it from `GET /jobs/{id}/transcript`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobResponse(
            string id,
            global::Speechmatics.CreateJobResponseStatus? status,
            object? jsonV2,
            string? txt,
            string? srt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.JsonV2 = jsonV2;
            this.Txt = txt;
            this.Srt = srt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobResponse" /> class.
        /// </summary>
        public CreateJobResponse()
        {
        }

    }
}