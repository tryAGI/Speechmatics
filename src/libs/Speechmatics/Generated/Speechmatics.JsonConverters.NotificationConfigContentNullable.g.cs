#nullable enable

namespace Speechmatics.JsonConverters
{
    /// <inheritdoc />
    public sealed class NotificationConfigContentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechmatics.NotificationConfigContent?>
    {
        /// <inheritdoc />
        public override global::Speechmatics.NotificationConfigContent? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Speechmatics.NotificationConfigContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechmatics.NotificationConfigContent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechmatics.NotificationConfigContent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechmatics.NotificationConfigContent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Speechmatics.NotificationConfigContentExtensions.ToValueString(value.Value));
            }
        }
    }
}
