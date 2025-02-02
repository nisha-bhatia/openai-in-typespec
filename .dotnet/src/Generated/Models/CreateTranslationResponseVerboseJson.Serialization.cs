// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class CreateTranslationResponseVerboseJson : IJsonModel<CreateTranslationResponseVerboseJson>
    {
        void IJsonModel<CreateTranslationResponseVerboseJson>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranslationResponseVerboseJson>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateTranslationResponseVerboseJson)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("task"u8);
            writer.WriteStringValue(Task.ToString());
            writer.WritePropertyName("language"u8);
            writer.WriteStringValue(Language);
            writer.WritePropertyName("duration"u8);
            writer.WriteNumberValue(Convert.ToInt32(Duration.ToString("%s")));
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsCollectionDefined(Segments))
            {
                writer.WritePropertyName("segments"u8);
                writer.WriteStartArray();
                foreach (var item in Segments)
                {
                    writer.WriteObjectValue<TranscriptionSegment>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CreateTranslationResponseVerboseJson IJsonModel<CreateTranslationResponseVerboseJson>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranslationResponseVerboseJson>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateTranslationResponseVerboseJson)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateTranslationResponseVerboseJson(document.RootElement, options);
        }

        internal static CreateTranslationResponseVerboseJson DeserializeCreateTranslationResponseVerboseJson(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CreateTranslationResponseVerboseJsonTask task = default;
            string language = default;
            TimeSpan duration = default;
            string text = default;
            IReadOnlyList<TranscriptionSegment> segments = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("task"u8))
                {
                    task = new CreateTranslationResponseVerboseJsonTask(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = TimeSpan.FromSeconds(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TranscriptionSegment> array = new List<TranscriptionSegment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TranscriptionSegment.DeserializeTranscriptionSegment(item, options));
                    }
                    segments = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CreateTranslationResponseVerboseJson(
                task,
                language,
                duration,
                text,
                segments ?? new ChangeTrackingList<TranscriptionSegment>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateTranslationResponseVerboseJson>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranslationResponseVerboseJson>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateTranslationResponseVerboseJson)} does not support writing '{options.Format}' format.");
            }
        }

        CreateTranslationResponseVerboseJson IPersistableModel<CreateTranslationResponseVerboseJson>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateTranslationResponseVerboseJson>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateTranslationResponseVerboseJson(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateTranslationResponseVerboseJson)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateTranslationResponseVerboseJson>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateTranslationResponseVerboseJson FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateTranslationResponseVerboseJson(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
