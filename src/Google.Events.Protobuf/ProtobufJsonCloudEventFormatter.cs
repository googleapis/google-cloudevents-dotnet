// Copyright 2021, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using CloudNative.CloudEvents;
using CloudNative.CloudEvents.SystemTextJson;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace Google.Events.Protobuf
{
    /// <summary>
    /// <see cref="CloudEventFormatter"/> which is able to serialize protobuf messages in JSON.
    /// (Note that this does not implement the protobuf CloudEvent format, which is separate.)
    /// </summary>
    /// <typeparam name="T">The type of message to serialize/deserialize</typeparam>
    public class ProtobufJsonCloudEventFormatter<T> : CloudEventFormatter where T : class, IMessage<T>, new()
    {
        private static readonly JsonParser s_jsonParser = new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

        // Note: although we delegate to a JsonEventFormatter (via StructuredEventFormatter) and *could* just derive from JsonEventFormatter,
        // that would provide less flexibility for the future.
        private static readonly CloudEventFormatter s_structuredEventFormatter = new StructuredEventFormatter();

        /// <inheritdoc />
        public override void DecodeBinaryModeEventData(byte[] data, CloudEvent cloudEvent) =>
            cloudEvent.Data = data.Length == 0 ? null : s_jsonParser.Parse<T>(new StreamReader(new MemoryStream(data)));

        // TODO: Handle other structured modes beyond JSON?

        /// <inheritdoc />
        public override CloudEvent DecodeStructuredModeMessage(byte[] data, ContentType contentType, IEnumerable<CloudEventAttribute> extensionAttributes) =>
            s_structuredEventFormatter.DecodeStructuredModeMessage(data, contentType, extensionAttributes);

        /// <inheritdoc />
        public override IReadOnlyList<CloudEvent> DecodeBatchModeMessage(byte[] data, ContentType contentType, IEnumerable<CloudEventAttribute> extensionAttributes) =>
            s_structuredEventFormatter.DecodeBatchModeMessage(data, contentType, extensionAttributes);

        /// <inheritdoc />
        public override byte[] EncodeBinaryModeEventData(CloudEvent cloudEvent)
        {
            var data = (T)cloudEvent.Data;
            if (data is null)
            {
                return Array.Empty<byte>();
            }
            var json = data.ToString();
            return Encoding.UTF8.GetBytes(json);
        }

        /// <inheritdoc />
        public override byte[] EncodeStructuredModeMessage(CloudEvent cloudEvent, out ContentType contentType) =>
            s_structuredEventFormatter.EncodeStructuredModeMessage(cloudEvent, out contentType);

        /// <inheritdoc />
        public override byte[] EncodeBatchModeMessage(IEnumerable<CloudEvent> cloudEvents, out ContentType contentType) =>
            s_structuredEventFormatter.EncodeBatchModeMessage(cloudEvents, out contentType);

        private class StructuredEventFormatter : JsonEventFormatter
        {
            protected override void EncodeStructuredModeData(CloudEvent cloudEvent, Utf8JsonWriter writer)
            {
                writer.WritePropertyName("data");
                // TODO: Try to make this cleaner. It's annoying that we have to convert to a JSON string,
                // reparse, then reserialize.
                using var document = JsonDocument.Parse(cloudEvent.Data.ToString());
                document.WriteTo(writer);
            }

            protected override void DecodeStructuredModeDataProperty(JsonElement dataElement, CloudEvent cloudEvent)
            {
                if (dataElement.ValueKind != JsonValueKind.Object)
                {
                    throw new InvalidOperationException("Expected Data property to have an object value");
                }
                string json = dataElement.GetRawText();
                cloudEvent.Data = s_jsonParser.Parse<T>(json);
            }

            protected override void DecodeStructuredModeDataBase64Property(JsonElement dataBase64Element, CloudEvent cloudEvent)
            {
                throw new InvalidOperationException("Expected Data property to be set");
            }
        }
    }
}
