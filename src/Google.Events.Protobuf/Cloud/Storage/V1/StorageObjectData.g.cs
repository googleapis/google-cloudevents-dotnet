// Copyright 2024, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Storage.V1
{    
    [global::CloudNative.CloudEvents.CloudEventFormatterAttribute(typeof(ProtobufJsonCloudEventFormatter<StorageObjectData>))]
    public partial class StorageObjectData
    {
        /// <summary>CloudEvent type for the 'finalized' event.</summary>
        public const string FinalizedCloudEventType = "google.cloud.storage.object.v1.finalized";

        /// <summary>CloudEvent type for the 'archived' event.</summary>
        public const string ArchivedCloudEventType = "google.cloud.storage.object.v1.archived";

        /// <summary>CloudEvent type for the 'deleted' event.</summary>
        public const string DeletedCloudEventType = "google.cloud.storage.object.v1.deleted";

        /// <summary>CloudEvent type for the 'metadataUpdated' event.</summary>
        public const string MetadataUpdatedCloudEventType = "google.cloud.storage.object.v1.metadataUpdated";

    }
}
