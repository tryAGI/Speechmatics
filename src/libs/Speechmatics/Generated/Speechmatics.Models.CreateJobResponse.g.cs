
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
        /// **Note**: Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.CreateJobResponseStatusJsonConverter))]
        public global::Speechmatics.CreateJobResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json-v2")]
        public global::Speechmatics.RetrieveTranscriptResponse? JsonV2 { get; set; }

        /// <summary>
        /// **Note**: Only available on SaaS on Cloud. The transcript in plain text, embedded when `status` is `done` and `format` was `txt`. Best-effort: if absent, fetch it from `GET /jobs/{jobid}/transcript`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txt")]
        public string? Txt { get; set; }

        /// <summary>
        /// **Note**: Only available on SaaS on Cloud. The transcript in SRT format, embedded when `status` is `done` and `format` was `srt`. Best-effort: if absent, fetch it from `GET /jobs/{jobid}/transcript`.
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
        /// **Note**: Only available on SaaS on Cloud. Present only when the `wait` query parameter is set. Reports the outcome of the wait, which is distinct from the job lifecycle status returned by `GET /jobs/{jobid}`. * `created` - the job was created and is still running, or `wait` elapsed before it finished. * `done` - the job finished; the transcript is embedded under the requested `format` key when available. * `rejected` - the job could not be processed. * `deleted` - the job was deleted before it could finish.
        /// </param>
        /// <param name="jsonV2"></param>
        /// <param name="txt">
        /// **Note**: Only available on SaaS on Cloud. The transcript in plain text, embedded when `status` is `done` and `format` was `txt`. Best-effort: if absent, fetch it from `GET /jobs/{jobid}/transcript`.
        /// </param>
        /// <param name="srt">
        /// **Note**: Only available on SaaS on Cloud. The transcript in SRT format, embedded when `status` is `done` and `format` was `srt`. Best-effort: if absent, fetch it from `GET /jobs/{jobid}/transcript`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobResponse(
            string id,
            global::Speechmatics.CreateJobResponseStatus? status,
            global::Speechmatics.RetrieveTranscriptResponse? jsonV2,
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