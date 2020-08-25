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
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Firebase.RemoteConfig.V1
{
    /// <summary>
    /// The data within all Firebase Remote Config events.
    /// </summary>
    public partial class RemoteConfigEventData
    {
        /// <summary>
        /// The version number of the version's corresponding Remote Config template.
        /// </summary>
        [JsonPropertyName("versionNumber")]
        public long VersionNumber { get; set; }

        /// <summary>
        /// When the Remote Config template was written to the Remote Config server.
        /// </summary>
        [JsonPropertyName("updateTime")]
        public DateTimeOffset? UpdateTime { get; set; }

        /// <summary>
        /// Aggregation of all metadata fields about the account that performed the update.
        /// </summary>
        [JsonPropertyName("updateUser")]
        public RemoteConfigUser? UpdateUser { get; set; }

        /// <summary>
        /// The user-provided description of the corresponding Remote Config template.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Where the update action originated.
        /// </summary>
        [JsonPropertyName("updateOrigin")]
        public RemoteConfigUpdateOrigin UpdateOrigin { get; set; }

        /// <summary>
        /// What type of update was made.
        /// </summary>
        [JsonPropertyName("updateType")]
        public RemoteConfigUpdateType? UpdateType { get; set; }

        /// <summary>
        /// Only present if this version is the result of a rollback, and will be the
        /// version number of the Remote Config template that was rolled-back to.
        /// </summary>
        [JsonPropertyName("rollbackSource")]
        public long RollbackSource { get; set; }
    }

    /// <summary>
    /// All the fields associated with the person/service account
    /// that wrote a Remote Config template.
    /// </summary>
    public class RemoteConfigUser
    {
        /// <summary>
        /// Display name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Image URL.
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
    }

    /// <summary>
    /// What type of update was associated with the Remote Config template version.
    /// </summary>
    public enum RemoteConfigUpdateOrigin
    {
        /// <summary>
        /// Catch-all for unrecognized values.
        /// </summary>
        REMOTE_CONFIG_UPDATE_ORIGIN_UNSPECIFIED = 0,

        /// <summary>
        /// The update came from the Firebase UI.
        /// </summary>
        CONSOLE = 1,

        /// <summary>
        /// The update came from the Remote Config REST API.
        /// </summary>
        REST_API = 2,

        /// <summary>
        /// The update came from the Firebase Admin Node SDK.
        /// </summary>
        ADMIN_SDK_NODE = 3
    }

    /// <summary>
    /// Where the Remote Config update action originated.
    /// </summary>
    public enum RemoteConfigUpdateType
    {
        /// <summary>
        /// Catch-all for unrecognized enum values.
        /// </summary>
        REMOTE_CONFIG_UPDATE_TYPE_UNSPECIFIED = 0,

        /// <summary>
        /// A regular incremental update.
        /// </summary>
        INCREMENTAL_UPDATE = 1,

        /// <summary>
        /// A forced update.
        /// The ETag was specified as "*" in an UpdateRemoteConfigRequest
        /// request or the "Force Update" button was pressed on the console.
        /// </summary>
        FORCED_UPDATE = 2,

        /// <summary>
        /// A rollback to a previous Remote Config template.
        /// </summary>
        ROLLBACK = 3
    }
}
