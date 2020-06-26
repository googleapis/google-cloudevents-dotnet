// Copyright 2020, Google LLC
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

#nullable enable

using System.Collections.Generic;
using System.Text.Json.Serialization;

// Note: eventually, we'd like this to be generated.

namespace Google.Events.SystemTextJson.Cloud.PubSub.V1
{
    /// <summary>
    /// The CloudEvent representation of a PubSub message as translated from a GCF event.
    /// </summary>
    [CloudEventDataConverter(typeof(JsonCloudEventDataConverter<MessagePublishedData>))]
    public sealed partial class MessagePublishedData
    {
        /// <summary>
        /// The resource name of the subscription receiving this message.
        /// This property is not always populated.
        /// </summary>
        [JsonPropertyName("subscription")]
        public string? Subscription { get; set; }

        /// <summary>
        /// The message that was published.
        /// </summary>
        [JsonPropertyName("message")]
        public PubsubMessage? Message { get; set; }
    }

    /// <summary>
    /// A PubSub message received as part of a <see cref="MessagePublishedData"/>
    /// </summary>
    public sealed partial class PubsubMessage
    {
        /// <summary>
        /// Attributes for the message. If this is not provided in the event data directly,
        /// it will be an empty dictionary.
        /// </summary>
        [JsonPropertyName("attributes")]
        public IDictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// The binary data in the event.
        /// </summary>
        [JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// The ID of the message.
        /// </summary>
        [JsonPropertyName("messageId")]
        public string? MessageId { get; set; }
    }
}
