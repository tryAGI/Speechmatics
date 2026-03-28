
#nullable enable

namespace Speechmatics
{
    public sealed partial class SpeechmaticsClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Speechmatics.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Authorization",
                Value = apiKey,
            });
        }
    }
}