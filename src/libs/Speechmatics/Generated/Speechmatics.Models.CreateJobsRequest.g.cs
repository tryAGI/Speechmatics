
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateJobsRequest
    {
        /// <summary>
        /// JSON containing a `JobConfig` model indicating the type and parameters for the recognition job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_file")]
        public byte[]? DataFile { get; set; }

        /// <summary>
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_filename")]
        public string? DataFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// JSON containing a `JobConfig` model indicating the type and parameters for the recognition job.
        /// </param>
        /// <param name="dataFile">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
        /// <param name="dataFilename">
        /// The data file to be processed. Alternatively the data file can be fetched from a url specified in `JobConfig`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJobsRequest(
            string config,
            byte[]? dataFile,
            string? dataFilename)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.DataFile = dataFile;
            this.DataFilename = dataFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobsRequest" /> class.
        /// </summary>
        public CreateJobsRequest()
        {
        }

    }
}