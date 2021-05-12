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
using Google.Events.Protobuf.Cloud.Storage.V1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Xunit;

namespace Google.Events.Protobuf.Tests
{
    public class ProtobufJsonCloudEventFormatterTest
    {
        [Fact]
        public void DecodeStructured()
        {
            var bytes = TestResourceHelper.LoadBytes("structured-mode-body.json");
            var expectedEvent = CreateSampleEvent();

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualEvent = converter.DecodeStructuredModeMessage(bytes, new ContentType("application/cloudevents+json"), null);
            AssertCloudEventsEqual(expectedEvent, actualEvent);
        }

        [Fact]
        public void DecodeStructured_NoData()
        {
            var bytes = TestResourceHelper.LoadBytes("structured-mode-body-no-data.json");
            var expectedEvent = CreateSampleEvent();
            expectedEvent.Data = null;

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualEvent = converter.DecodeStructuredModeMessage(bytes, new ContentType("application/cloudevents+json"), null);
            AssertCloudEventsEqual(expectedEvent, actualEvent);
        }

        [Theory]
        [InlineData("structured-mode-body-string-data.json")]
        [InlineData("structured-mode-body-base64.json")]
        public void DecodeStructured_Invalid(string resource)
        {
            var bytes = TestResourceHelper.LoadBytes(resource);
            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            Assert.Throws<InvalidOperationException>(() => converter.DecodeStructuredModeMessage(bytes, null, null));
        }

        [Fact]
        public void DecodeBinary()
        {
            var bytes = TestResourceHelper.LoadBytes("binary-mode-body.json");
            var cloudEvent = CreateSampleEvent();
            var expectedData = cloudEvent.Data;
            cloudEvent.Data = null;

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            converter.DecodeBinaryModeEventData(bytes, cloudEvent);
            var actualData = cloudEvent.Data;
            Assert.Equal(expectedData, actualData);
        }

        [Fact]
        public void DecodeBinary_NoData()
        {
            var cloudEvent = CreateSampleEvent();

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            converter.DecodeBinaryModeEventData(new byte[0], cloudEvent);
            Assert.Null(cloudEvent.Data);
        }

        [Fact]
        public void DecodeBatch()
        {
            var bytes = TestResourceHelper.LoadBytes("batch-body.json");
            var expectedEvent1 = CreateSampleEvent();
            var expectedEvent2 = CreateSampleEvent2();

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualEvents = converter.DecodeBatchModeMessage(bytes, new ContentType("application/cloudevents-batch+json"), null);

            Assert.Equal(2, actualEvents.Count);
            AssertCloudEventsEqual(expectedEvent1, actualEvents[0]);
            AssertCloudEventsEqual(expectedEvent2, actualEvents[1]);
        }

        [Fact]
        public void EncodeStructured()
        {
            var cloudEvent = CreateSampleEvent();
            var expectedBytes = TestResourceHelper.LoadBytes("structured-mode-body.json");

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualBytes = converter.EncodeStructuredModeMessage(cloudEvent, out var contentType);
            Assert.Equal("application/cloudevents+json", contentType.MediaType);

            AssertJsonBytesEqual(expectedBytes, actualBytes);
        }

        [Fact]
        public void EncodeStructured_NoData()
        {
            var cloudEvent = CreateSampleEvent();
            cloudEvent.Data = null;

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var bytes = converter.EncodeStructuredModeMessage(cloudEvent, out var contentType);
            Assert.Equal("application/cloudevents+json", contentType.MediaType);

            var obj = JObject.Parse(Encoding.UTF8.GetString(bytes));
            Assert.False(obj.ContainsKey("data"));
        }

        [Fact]
        public void EncodeBinary()
        {
            var cloudEvent = CreateSampleEvent();
            var expectedBytes = TestResourceHelper.LoadBytes("binary-mode-body.json");

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualBytes = converter.EncodeBinaryModeEventData(cloudEvent);

            AssertJsonBytesEqual(expectedBytes, actualBytes);
        }

        [Fact]
        public void EncodeBinary_NoData()
        {
            var cloudEvent = CreateSampleEvent();
            cloudEvent.Data = null;

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            Assert.Empty(converter.EncodeBinaryModeEventData(cloudEvent));
        }

        [Fact]
        public void EncodeBatch()
        {
            var batch = new[] { CreateSampleEvent(), CreateSampleEvent2() };
            var expectedBytes = TestResourceHelper.LoadBytes("batch-body.json");

            var converter = new ProtobufJsonCloudEventFormatter<StorageObjectData>();
            var actualBytes = converter.EncodeBatchModeMessage(batch, out var contentType);
            Assert.Equal("application/cloudevents-batch+json", contentType.MediaType);

            AssertJsonBytesEqual(expectedBytes, actualBytes);
        }

        private static void AssertJsonBytesEqual(byte[] expected, byte[] actual)
        {
            JToken expectedObject = Parse(expected);
            JToken actualObject = Parse(actual);
            Assert.Equal(expectedObject, actualObject);

            JToken Parse(byte[] bytes)
            {
                using JsonTextReader reader = new JsonTextReader(new StreamReader(new MemoryStream(bytes)))
                {
                    DateParseHandling = DateParseHandling.None
                };
                return CloneSorted(JToken.Load(reader));
            }

            JToken CloneSorted(JToken token) =>
                token.Type switch
                {
                    JTokenType.Object => CloneSortedObject((JObject) token),
                    JTokenType.Array => new JArray(((JArray) token).Select(CloneSorted)),
                    _ => token
                };

            JObject CloneSortedObject(JObject input)
            {
                var ret = new JObject();
                foreach (var property in input.Properties().OrderBy(prop => prop.Name, StringComparer.Ordinal))
                {
                    ret.Add(property.Name, CloneSorted(property.Value));
                }
                return ret;
            }
        }

        private static void AssertCloudEventsEqual(CloudEvent expected, CloudEvent actual)
        {
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Source, actual.Source);
            Assert.Equal(expected.Subject, actual.Subject);
            Assert.Equal(expected.Data, actual.Data);
        }

        private static CloudEvent CreateSampleEvent() =>
            new CloudEvent
            {
                Id = "sample-event-id",
                Type = StorageObjectData.FinalizedCloudEventType,
                Source = new Uri("//storage.googleapis.com/projects/_/buckets/sample-bucket", UriKind.RelativeOrAbsolute),
                Subject = "folder/Test.cs",
                Data = new StorageObjectData
                {
                    Bucket = "sample-bucket",
                    ContentType = "text/plain",
                    Generation = 1587627537231057,
                    Name = "folder/Test.cs"
                }
            };

        // A second event used for batch testing
        private static CloudEvent CreateSampleEvent2() =>
            new CloudEvent
            {
                Id = "sample-event-id-2",
                Type = StorageObjectData.ArchivedCloudEventType,
                Source = new Uri("//storage.googleapis.com/projects/_/buckets/sample-bucket-2", UriKind.RelativeOrAbsolute),
                Subject = "object.txt",
                Data = new StorageObjectData
                {
                    Bucket = "sample-bucket-2",
                    ContentType = "application/json",
                    Generation = 12345,
                    Name = "object.txt"
                }
            };
    }
}