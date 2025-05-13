// Copyright 2025, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Metastore.V1
{    
    [global::CloudNative.CloudEvents.CloudEventFormatterAttribute(typeof(ProtobufJsonCloudEventFormatter<MetadataImportEventData>))]
    public partial class MetadataImportEventData
    {
        /// <summary>CloudEvent type for the 'created' event.</summary>
        public const string CreatedCloudEventType = "google.cloud.metastore.metadataImport.v1.created";

        /// <summary>CloudEvent type for the 'updated' event.</summary>
        public const string UpdatedCloudEventType = "google.cloud.metastore.metadataImport.v1.updated";

    }
}
