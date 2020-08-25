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

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Firebase.Database.V1
{
    /// <summary>
    /// The CloudEvent representation of Firebase Database event as translated from a GCF event.
    /// </summary>
    public sealed partial class ReferenceEventData
    {
        /// <summary>
        /// The data before the event took place.
        /// </summary>
        [JsonPropertyName("data")]
        public JsonElement? Data { get; set; }

        /// <summary>
        /// The change in the document.
        /// </summary>
        [JsonPropertyName("delta")]
        public JsonElement? Delta { get; set; }
    }
}
