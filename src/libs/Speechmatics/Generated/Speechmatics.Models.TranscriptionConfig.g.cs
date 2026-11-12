
#nullable enable

namespace Speechmatics
{
    /// <summary>
    /// Example: {"language":"en","output_locale":"en-GB","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Caller","Agent"]}
    /// </summary>
    public sealed partial class TranscriptionConfig
    {
        /// <summary>
        /// Language model to process the audio input, normally specified as an ISO language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Request a specialized model based on 'language' but optimized for a particular field, e.g. 'finance' or 'medical'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Language locale to be used when generating the transcription output, normally specified as an ISO language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_locale")]
        public string? OutputLocale { get; set; }

        /// <summary>
        /// Specific model to use in transcription, alias to operating point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// List of languages expected to be present in the audio, specified as ISO language codes. This is used to guide the transcription process, particularly for multilingual audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// Whether to treat the provided language hints as strict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints_strict")]
        public bool? LanguageHintsStrict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_point")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.OperatingPointJsonConverter))]
        public global::Speechmatics.OperatingPoint? OperatingPoint { get; set; }

        /// <summary>
        /// List of custom words or phrases that should be recognized. Alternative pronunciations can be specified to aid recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_vocab")]
        public global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>? AdditionalVocab { get; set; }

        /// <summary>
        /// Control punctuation settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuation_overrides")]
        public global::Speechmatics.TranscriptionConfigPunctuationOverrides? PunctuationOverrides { get; set; }

        /// <summary>
        /// Specify whether speaker or channel labels are added to the transcript.<br/>
        /// The default is `none`.<br/>
        ///   - **none**: no speaker or channel labels are added.<br/>
        ///   - **speaker**: speaker attribution is performed based on acoustic matching;<br/>
        ///              all input channels are mixed into a single stream for processing.<br/>
        ///   - **channel**: multiple input channels are processed individually and collated<br/>
        ///             into a single transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.TranscriptionConfigDiarizationJsonConverter))]
        public global::Speechmatics.TranscriptionConfigDiarization? Diarization { get; set; }

        /// <summary>
        /// Transcript labels to use when using collating separate input channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_diarization_labels")]
        public global::System.Collections.Generic.IList<string>? ChannelDiarizationLabels { get; set; }

        /// <summary>
        /// Include additional 'entity' objects in the transcription results (e.g. dates, numbers) and their original spoken form. These entities are interleaved with other types of results. The concatenation of these words is represented as a single entity with the concatenated written form present in the 'content' field. The entities contain a 'spoken_form' field, which can be used in place of the corresponding 'word' type results, in case a spoken form is preferred to a written form. They also contain a 'written_form', which can be used instead of the entity, if you want a breakdown of the words without spaces. They can still contain non-breaking spaces and other special whitespace characters, as they are considered part of the word for the formatting output. In case of a written_form, the individual word times are estimated and might not be accurate if the order of the words in the written form does not correspond to the order they were actually spoken (such as 'one hundred million dollars' and '$100 million').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_entities")]
        public bool? EnableEntities { get; set; }

        /// <summary>
        /// Configuration for Advanced Entities Detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities_config")]
        public global::Speechmatics.TranscriptionConfigEntitiesConfig? EntitiesConfig { get; set; }

        /// <summary>
        /// Redact advanced entities throughout the transcript: matching entity values are replaced with a consistent label based on the `entity_class` (e.g. "[name_given]"). Must be set together with `redaction_config.entity_classes`. If `enable_entities` is true, `entities_config.detect_advanced_entities` must also be true (redaction relies on advanced entity detection); if `enable_entities` is false or omitted, `enable_redaction` can be used on its own. Spoken and written forms are not available when redaction is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_redaction")]
        public bool? EnableRedaction { get; set; }

        /// <summary>
        /// Configuration for redaction. Required, and only applied, when `enable_redaction` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redaction_config")]
        public global::Speechmatics.TranscriptionConfigRedactionConfig? RedactionConfig { get; set; }

        /// <summary>
        /// Whether or not to enable flexible endpointing and allow the entity to continue to be spoken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_delay_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechmatics.JsonConverters.TranscriptionConfigMaxDelayModeJsonConverter))]
        public global::Speechmatics.TranscriptionConfigMaxDelayMode? MaxDelayMode { get; set; }

        /// <summary>
        /// Configuration for limiting the transcription of quiet audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_filtering_config")]
        public global::Speechmatics.TranscriptionConfigAudioFilteringConfig? AudioFilteringConfig { get; set; }

        /// <summary>
        /// Configuration for applying filtering to the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_filtering_config")]
        public global::Speechmatics.TranscriptionConfigTranscriptFilteringConfig? TranscriptFilteringConfig { get; set; }

        /// <summary>
        /// Configuration for speaker diarization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_diarization_config")]
        public global::Speechmatics.TranscriptionConfigSpeakerDiarizationConfig? SpeakerDiarizationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        /// <param name="language">
        /// Language model to process the audio input, normally specified as an ISO language code
        /// </param>
        /// <param name="domain">
        /// Request a specialized model based on 'language' but optimized for a particular field, e.g. 'finance' or 'medical'.
        /// </param>
        /// <param name="outputLocale">
        /// Language locale to be used when generating the transcription output, normally specified as an ISO language code
        /// </param>
        /// <param name="model">
        /// Specific model to use in transcription, alias to operating point.
        /// </param>
        /// <param name="languageHints">
        /// List of languages expected to be present in the audio, specified as ISO language codes. This is used to guide the transcription process, particularly for multilingual audio.
        /// </param>
        /// <param name="languageHintsStrict">
        /// Whether to treat the provided language hints as strict.
        /// </param>
        /// <param name="operatingPoint"></param>
        /// <param name="additionalVocab">
        /// List of custom words or phrases that should be recognized. Alternative pronunciations can be specified to aid recognition.
        /// </param>
        /// <param name="punctuationOverrides">
        /// Control punctuation settings.
        /// </param>
        /// <param name="diarization">
        /// Specify whether speaker or channel labels are added to the transcript.<br/>
        /// The default is `none`.<br/>
        ///   - **none**: no speaker or channel labels are added.<br/>
        ///   - **speaker**: speaker attribution is performed based on acoustic matching;<br/>
        ///              all input channels are mixed into a single stream for processing.<br/>
        ///   - **channel**: multiple input channels are processed individually and collated<br/>
        ///             into a single transcript.
        /// </param>
        /// <param name="channelDiarizationLabels">
        /// Transcript labels to use when using collating separate input channels.
        /// </param>
        /// <param name="enableEntities">
        /// Include additional 'entity' objects in the transcription results (e.g. dates, numbers) and their original spoken form. These entities are interleaved with other types of results. The concatenation of these words is represented as a single entity with the concatenated written form present in the 'content' field. The entities contain a 'spoken_form' field, which can be used in place of the corresponding 'word' type results, in case a spoken form is preferred to a written form. They also contain a 'written_form', which can be used instead of the entity, if you want a breakdown of the words without spaces. They can still contain non-breaking spaces and other special whitespace characters, as they are considered part of the word for the formatting output. In case of a written_form, the individual word times are estimated and might not be accurate if the order of the words in the written form does not correspond to the order they were actually spoken (such as 'one hundred million dollars' and '$100 million').
        /// </param>
        /// <param name="entitiesConfig">
        /// Configuration for Advanced Entities Detection.
        /// </param>
        /// <param name="enableRedaction">
        /// Redact advanced entities throughout the transcript: matching entity values are replaced with a consistent label based on the `entity_class` (e.g. "[name_given]"). Must be set together with `redaction_config.entity_classes`. If `enable_entities` is true, `entities_config.detect_advanced_entities` must also be true (redaction relies on advanced entity detection); if `enable_entities` is false or omitted, `enable_redaction` can be used on its own. Spoken and written forms are not available when redaction is enabled.
        /// </param>
        /// <param name="redactionConfig">
        /// Configuration for redaction. Required, and only applied, when `enable_redaction` is true.
        /// </param>
        /// <param name="maxDelayMode">
        /// Whether or not to enable flexible endpointing and allow the entity to continue to be spoken.
        /// </param>
        /// <param name="audioFilteringConfig">
        /// Configuration for limiting the transcription of quiet audio.
        /// </param>
        /// <param name="transcriptFilteringConfig">
        /// Configuration for applying filtering to the transcription
        /// </param>
        /// <param name="speakerDiarizationConfig">
        /// Configuration for speaker diarization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfig(
            string language,
            string? domain,
            string? outputLocale,
            string? model,
            global::System.Collections.Generic.IList<string>? languageHints,
            bool? languageHintsStrict,
            global::Speechmatics.OperatingPoint? operatingPoint,
            global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>? additionalVocab,
            global::Speechmatics.TranscriptionConfigPunctuationOverrides? punctuationOverrides,
            global::Speechmatics.TranscriptionConfigDiarization? diarization,
            global::System.Collections.Generic.IList<string>? channelDiarizationLabels,
            bool? enableEntities,
            global::Speechmatics.TranscriptionConfigEntitiesConfig? entitiesConfig,
            bool? enableRedaction,
            global::Speechmatics.TranscriptionConfigRedactionConfig? redactionConfig,
            global::Speechmatics.TranscriptionConfigMaxDelayMode? maxDelayMode,
            global::Speechmatics.TranscriptionConfigAudioFilteringConfig? audioFilteringConfig,
            global::Speechmatics.TranscriptionConfigTranscriptFilteringConfig? transcriptFilteringConfig,
            global::Speechmatics.TranscriptionConfigSpeakerDiarizationConfig? speakerDiarizationConfig)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Domain = domain;
            this.OutputLocale = outputLocale;
            this.Model = model;
            this.LanguageHints = languageHints;
            this.LanguageHintsStrict = languageHintsStrict;
            this.OperatingPoint = operatingPoint;
            this.AdditionalVocab = additionalVocab;
            this.PunctuationOverrides = punctuationOverrides;
            this.Diarization = diarization;
            this.ChannelDiarizationLabels = channelDiarizationLabels;
            this.EnableEntities = enableEntities;
            this.EntitiesConfig = entitiesConfig;
            this.EnableRedaction = enableRedaction;
            this.RedactionConfig = redactionConfig;
            this.MaxDelayMode = maxDelayMode;
            this.AudioFilteringConfig = audioFilteringConfig;
            this.TranscriptFilteringConfig = transcriptFilteringConfig;
            this.SpeakerDiarizationConfig = speakerDiarizationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        public TranscriptionConfig()
        {
        }

    }
}