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

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Api
{
    /// <summary>
    /// An object representing a resource that can be used for monitoring, logging,
    /// billing, or other purposes.
    /// </summary>
    public class MonitoredResource
    {
        /// <summary>
        /// Required. The monitored resource type. For example, the type of a 
        /// Compute Engine VM instance is `gce_instance`.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Values for all of the labels listed in the associated monitored
        /// resource descriptor. For example, Compute Engine VM instances use the
        /// labels `"project_id"`, `"instance_id"`, and `"zone"`.
        /// </summary>
        [JsonPropertyName("labels")]
        public IDictionary<string, string>? Labels { get; set; }
    }
}
