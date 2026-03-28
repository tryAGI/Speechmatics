
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Summary information about the output from an ASR job, comprising the job type and configuration parameters used when generating the output.
    /// </summary>
    public sealed partial class RecognitionMetadata
    {
        /// <summary>
        /// The UTC date time the transcription output was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </summary>
        /// <example>2018-01-09 12:29:01.853047+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.JobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechmatics.JobType Type { get; set; }

        /// <summary>
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </summary>
        /// <example>{"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_config")]
        public global::Speechmatics.TranscriptionConfig? TranscriptionConfig { get; set; }

        /// <summary>
        /// The engine version used to generate transcription output.<br/>
        /// Example: 2025.11.07+cd4ff775c0+14.7.0
        /// </summary>
        /// <example>2025.11.07+cd4ff775c0+14.7.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orchestrator_version")]
        public string? OrchestratorVersion { get; set; }

        /// <summary>
        /// List of errors that occurred in the translation stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_errors")]
        public global::System.Collections.Generic.IList<global::Speechmatics.TranslationError>? TranslationErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the summarization stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization_errors")]
        public global::System.Collections.Generic.IList<global::Speechmatics.SummarizationError>? SummarizationErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the sentiment analysis stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis_errors")]
        public global::System.Collections.Generic.IList<global::Speechmatics.SentimentAnalysisError>? SentimentAnalysisErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the topic detection stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_detection_errors")]
        public global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionError>? TopicDetectionErrors { get; set; }

        /// <summary>
        /// List of errors that occurred in the auto chapters stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters_errors")]
        public global::System.Collections.Generic.IList<global::Speechmatics.AutoChaptersResultError>? AutoChaptersErrors { get; set; }

        /// <summary>
        /// Example: {"language":"en"}
        /// </summary>
        /// <example>{"language":"en"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_config")]
        public global::Speechmatics.AlignmentConfig? AlignmentConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::Speechmatics.OutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// Properties of the language pack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_pack_info")]
        public global::Speechmatics.LanguagePackInfo? LanguagePackInfo { get; set; }

        /// <summary>
        /// Example: {"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}
        /// </summary>
        /// <example>{"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_identification")]
        public global::Speechmatics.LanguageIdentificationResult? LanguageIdentification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionMetadata" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UTC date time the transcription output was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </param>
        /// <param name="type"></param>
        /// <param name="transcriptionConfig">
        /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
        /// </param>
        /// <param name="orchestratorVersion">
        /// The engine version used to generate transcription output.<br/>
        /// Example: 2025.11.07+cd4ff775c0+14.7.0
        /// </param>
        /// <param name="translationErrors">
        /// List of errors that occurred in the translation stage.
        /// </param>
        /// <param name="summarizationErrors">
        /// List of errors that occurred in the summarization stage.
        /// </param>
        /// <param name="sentimentAnalysisErrors">
        /// List of errors that occurred in the sentiment analysis stage.
        /// </param>
        /// <param name="topicDetectionErrors">
        /// List of errors that occurred in the topic detection stage.
        /// </param>
        /// <param name="autoChaptersErrors">
        /// List of errors that occurred in the auto chapters stage.
        /// </param>
        /// <param name="alignmentConfig">
        /// Example: {"language":"en"}
        /// </param>
        /// <param name="outputConfig"></param>
        /// <param name="languagePackInfo">
        /// Properties of the language pack.
        /// </param>
        /// <param name="languageIdentification">
        /// Example: {"results":[{"alternatives":[{"language":"en","confidence":0.98},{"language":"fr","confidence":0.02}],"start_time":0,"end_time":5.5},{"alternatives":[{"language":"en","confidence":0.95},{"language":"fr","confidence":0.05}],"start_time":5.6,"end_time":10}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognitionMetadata(
            global::System.DateTime createdAt,
            global::Speechmatics.JobType type,
            global::Speechmatics.TranscriptionConfig? transcriptionConfig,
            string? orchestratorVersion,
            global::System.Collections.Generic.IList<global::Speechmatics.TranslationError>? translationErrors,
            global::System.Collections.Generic.IList<global::Speechmatics.SummarizationError>? summarizationErrors,
            global::System.Collections.Generic.IList<global::Speechmatics.SentimentAnalysisError>? sentimentAnalysisErrors,
            global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionError>? topicDetectionErrors,
            global::System.Collections.Generic.IList<global::Speechmatics.AutoChaptersResultError>? autoChaptersErrors,
            global::Speechmatics.AlignmentConfig? alignmentConfig,
            global::Speechmatics.OutputConfig? outputConfig,
            global::Speechmatics.LanguagePackInfo? languagePackInfo,
            global::Speechmatics.LanguageIdentificationResult? languageIdentification)
        {
            this.CreatedAt = createdAt;
            this.Type = type;
            this.TranscriptionConfig = transcriptionConfig;
            this.OrchestratorVersion = orchestratorVersion;
            this.TranslationErrors = translationErrors;
            this.SummarizationErrors = summarizationErrors;
            this.SentimentAnalysisErrors = sentimentAnalysisErrors;
            this.TopicDetectionErrors = topicDetectionErrors;
            this.AutoChaptersErrors = autoChaptersErrors;
            this.AlignmentConfig = alignmentConfig;
            this.OutputConfig = outputConfig;
            this.LanguagePackInfo = languagePackInfo;
            this.LanguageIdentification = languageIdentification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionMetadata" /> class.
        /// </summary>
        public RecognitionMetadata()
        {
        }
    }
}