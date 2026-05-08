
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Speechmatics
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Speechmatics.JsonConverters.ErrorResponseErrorJsonConverter),

            typeof(global::Speechmatics.JsonConverters.ErrorResponseErrorNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranslationErrorTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranslationErrorTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationErrorTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationErrorTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SentimentAnalysisErrorTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SentimentAnalysisErrorTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TopicDetectionErrorTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TopicDetectionErrorTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.AutoChaptersResultErrorTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.AutoChaptersResultErrorTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranscriptionConfigDiarizationJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranscriptionConfigDiarizationNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranscriptionConfigMaxDelayModeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.TranscriptionConfigMaxDelayModeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.NotificationConfigContentJsonConverter),

            typeof(global::Speechmatics.JsonConverters.NotificationConfigContentNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.NotificationConfigMethodJsonConverter),

            typeof(global::Speechmatics.JsonConverters.NotificationConfigMethodNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguagePackInfoWritingDirectionJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguagePackInfoWritingDirectionNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguageIdentificationConfigLowConfidenceActionJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguageIdentificationConfigLowConfidenceActionNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigContentTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigContentTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigSummaryLengthJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigSummaryLengthNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigSummaryTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SummarizationConfigSummaryTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobDetailsStatusJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobDetailsStatusNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionDisplayDirectionJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionDisplayDirectionNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionResultTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionResultTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionResultAttachesToJsonConverter),

            typeof(global::Speechmatics.JsonConverters.RecognitionResultAttachesToNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.WrittenFormRecognitionResultTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.WrittenFormRecognitionResultTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SpokenFormRecognitionResultTypeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.SpokenFormRecognitionResultTypeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguageIdentificationResultErrorJsonConverter),

            typeof(global::Speechmatics.JsonConverters.LanguageIdentificationResultErrorNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.OperatingPointJsonConverter),

            typeof(global::Speechmatics.JsonConverters.OperatingPointNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobModeJsonConverter),

            typeof(global::Speechmatics.JsonConverters.JobModeNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsTranscriptFormatJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsTranscriptFormatNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsAlignmentTagsJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsAlignmentTagsNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsObjectUrlsUrlForItemJsonConverter),

            typeof(global::Speechmatics.JsonConverters.GetJobsObjectUrlsUrlForItemNullableJsonConverter),

            typeof(global::Speechmatics.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.ErrorResponseError), TypeInfoPropertyName = "ErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TrackingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.DataFetchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AlignmentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranslationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranslationErrorType), TypeInfoPropertyName = "TranslationErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationErrorType), TypeInfoPropertyName = "SummarizationErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentAnalysisError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentAnalysisErrorType), TypeInfoPropertyName = "SentimentAnalysisErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionErrorType), TypeInfoPropertyName = "TopicDetectionErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AutoChaptersResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AutoChaptersResultErrorType), TypeInfoPropertyName = "AutoChaptersResultErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.OperatingPoint), TypeInfoPropertyName = "OperatingPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigAdditionalVocabItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigPunctuationOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigDiarization), TypeInfoPropertyName = "TranscriptionConfigDiarization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigMaxDelayMode), TypeInfoPropertyName = "TranscriptionConfigMaxDelayMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigAudioFilteringConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigTranscriptFilteringConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranscriptionConfigSpeakerDiarizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SpeakersInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SpeakersInputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.NotificationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.NotificationConfigContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.NotificationConfigContent), TypeInfoPropertyName = "NotificationConfigContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.NotificationConfigMethod), TypeInfoPropertyName = "NotificationConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguagePackInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguagePackInfoWritingDirection), TypeInfoPropertyName = "LanguagePackInfoWritingDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.OutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.OutputConfigSrtOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobType), TypeInfoPropertyName = "JobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.NotificationConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranslationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentAnalysisConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AutoChaptersConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AudioEventsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationConfigLowConfidenceAction), TypeInfoPropertyName = "LanguageIdentificationConfigLowConfidenceAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationConfigContentType), TypeInfoPropertyName = "SummarizationConfigContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationConfigSummaryLength), TypeInfoPropertyName = "SummarizationConfigSummaryLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationConfigSummaryType), TypeInfoPropertyName = "SummarizationConfigSummaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.CreateJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobDetailsStatus), TypeInfoPropertyName = "JobDetailsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.JobDetailError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobDetailError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RetrieveJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.JobDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RetrieveJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.DeleteJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TranslationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SummarizationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SentimentAnalysisError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.AutoChaptersResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionDisplay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionDisplayDirection), TypeInfoPropertyName = "RecognitionDisplayDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionAlternative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionResultType), TypeInfoPropertyName = "RecognitionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.WrittenFormRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.WrittenFormRecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SpokenFormRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SpokenFormRecognitionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.RecognitionAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RecognitionResultAttachesTo), TypeInfoPropertyName = "RecognitionResultAttachesTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.WrittenFormRecognitionResultType), TypeInfoPropertyName = "WrittenFormRecognitionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SpokenFormRecognitionResultType), TypeInfoPropertyName = "SpokenFormRecognitionResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RetrieveTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.RecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SpeakersResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SpeakersResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Speechmatics.TranslationSentence>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TranslationSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TranslationSentence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SummarizationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.AudioEventItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AudioEventItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RetrieveTranscriptResponseAudioEventSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Speechmatics.AudioEventSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::Speechmatics.AudioEventSummaryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentAnalysisResultSentimentAnalysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SentimentSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentSummaryDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SentimentSpeakerSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentSpeakerSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.SentimentChannelSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.SentimentChannelSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.TopicDetectionSegmentTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.TopicDetectionSegmentTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.Chapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.AudioEventSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.LanguageIdentificationResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationResultError), TypeInfoPropertyName = "LanguageIdentificationResultError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.LanguageIdentificationResultAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.LanguageIdentificationResultAlternative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.JobMode), TypeInfoPropertyName = "JobMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.UsageDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.UsageDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.RetrieveObjectUrlsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.CreateJobsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.GetJobsTranscriptFormat), TypeInfoPropertyName = "GetJobsTranscriptFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.GetJobsAlignmentTags), TypeInfoPropertyName = "GetJobsAlignmentTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechmatics.GetJobsObjectUrlsUrlForItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechmatics.GetJobsObjectUrlsUrlForItem), TypeInfoPropertyName = "GetJobsObjectUrlsUrlForItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TranscriptionConfigAdditionalVocabItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TranscriptionConfigTranscriptFilteringConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SpeakersInputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.NotificationConfigContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.NotificationConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.JobDetailError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.JobDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TranslationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SummarizationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SentimentAnalysisError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.AutoChaptersResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.WrittenFormRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SpokenFormRecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.RecognitionAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.RecognitionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SpeakersResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Speechmatics.TranslationSentence>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TranslationSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.AudioEventItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SentimentSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SentimentSpeakerSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.SentimentChannelSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.TopicDetectionSegmentTopic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.LanguageIdentificationResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.LanguageIdentificationResultAlternative>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.UsageDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechmatics.GetJobsObjectUrlsUrlForItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}