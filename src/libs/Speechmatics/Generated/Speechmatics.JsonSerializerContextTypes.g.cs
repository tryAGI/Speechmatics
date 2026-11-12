
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechmatics
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.ErrorResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.ErrorResponseError? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TrackingData? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.DataFetchConfig? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranslationError? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranslationErrorType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationError? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationErrorType? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentAnalysisError? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentAnalysisErrorType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionError? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionErrorType? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AutoChaptersResultError? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AutoChaptersResultErrorType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfig? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.OperatingPoint? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigAdditionalVocabItem? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigPunctuationOverrides? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigDiarization? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigEntitiesConfig? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigRedactionConfig? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigRedactionConfigEntityClasse>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigRedactionConfigEntityClasse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigMaxDelayMode? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigAudioFilteringConfig? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigTranscriptFilteringConfig? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranscriptionConfigSpeakerDiarizationConfig? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SpeakersInputItem>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SpeakersInputItem? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.NotificationConfig? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.NotificationConfigContent>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.NotificationConfigContent? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.NotificationConfigMethod? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguagePackInfo? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Speechmatics.LanguagePackInfoPerLanguageWritingDirection2>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguagePackInfoPerLanguageWritingDirection2? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguagePackInfoWritingDirection? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.OutputConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.OutputConfigSrtOverrides? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobConfig? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.NotificationConfig>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranslationConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationConfig? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationConfig? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentAnalysisConfig? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionConfig? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AutoChaptersConfig? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AudioEventsConfig? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationConfigLowConfidenceAction? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationConfigContentType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationConfigSummaryLength? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationConfigSummaryType? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.CreateJobResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.CreateJobResponseStatus? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobDetails? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobDetailsStatus? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.JobDetailError>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobDetailError? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RetrieveJobsResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.JobDetails>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RetrieveJobResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.DeleteJobResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobInfo? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionMetadata? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TranslationError>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SummarizationError>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SentimentAnalysisError>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionError>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.AutoChaptersResultError>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationResult? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionDisplay? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionDisplayDirection? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionAlternative? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionResult? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionResultType? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.WrittenFormRecognitionResult>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.WrittenFormRecognitionResult? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SpokenFormRecognitionResult>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SpokenFormRecognitionResult? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.RecognitionAlternative>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RecognitionResultAttachesTo? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.WrittenFormRecognitionResultType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SpokenFormRecognitionResultType? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RetrieveTranscriptResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.RecognitionResult>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SpeakersResultItem>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SpeakersResultItem? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Speechmatics.TranslationSentence>>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TranslationSentence>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TranslationSentence? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SummarizationResult? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentAnalysisResult? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionResult? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.Chapter>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.AudioEventItem>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AudioEventItem? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.RetrieveTranscriptResponseAudioEventSummary? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Speechmatics.AudioEventSummaryItem>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Speechmatics.AudioEventSummaryItem>>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentAnalysisResultSentimentAnalysis? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SentimentSegment>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentSegment? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentSummary? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentSummaryDetail? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SentimentSpeakerSummary>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentSpeakerSummary? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.SentimentChannelSummary>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.SentimentChannelSummary? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionSegment>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionSegment? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionSummary? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionSegmentTopic>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.TopicDetectionSegmentTopic? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.Chapter? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.AudioEventSummaryItem? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.LanguageIdentificationResultItem>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationResultItem? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationResultError? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.LanguageIdentificationResultAlternative>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.LanguageIdentificationResultAlternative? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.Model? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.JobMode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.UsageResponse? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Speechmatics.UsageDetails>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.UsageDetails? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.CreateJobsRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.CreateJobsFormat? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Speechmatics.GetJobsTranscriptFormat? Type142 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TranscriptionConfigRedactionConfigEntityClasse>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SpeakersInputItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.NotificationConfigContent>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.NotificationConfig>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.JobDetailError>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.JobDetails>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TranslationError>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SummarizationError>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SentimentAnalysisError>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionError>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.AutoChaptersResultError>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.WrittenFormRecognitionResult>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SpokenFormRecognitionResult>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.RecognitionAlternative>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.RecognitionResult>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SpeakersResultItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Speechmatics.TranslationSentence>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TranslationSentence>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.Chapter>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.AudioEventItem>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SentimentSegment>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SentimentSpeakerSummary>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.SentimentChannelSummary>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionSegment>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionSegmentTopic>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.LanguageIdentificationResultItem>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.LanguageIdentificationResultAlternative>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Speechmatics.UsageDetails>? ListType30 { get; set; }
    }
}