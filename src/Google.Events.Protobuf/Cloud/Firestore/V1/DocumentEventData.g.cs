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

namespace Google.Events.Protobuf.Cloud.Firestore.V1
{    
    [global::CloudNative.CloudEvents.CloudEventFormatterAttribute(typeof(ProtobufJsonCloudEventFormatter<DocumentEventData>))]
    public partial class DocumentEventData
    {
        /// <summary>CloudEvent type for the 'created' event.</summary>
        public const string CreatedCloudEventType = "google.cloud.firestore.document.v1.created";

        /// <summary>CloudEvent type for the 'updated' event.</summary>
        public const string UpdatedCloudEventType = "google.cloud.firestore.document.v1.updated";

        /// <summary>CloudEvent type for the 'deleted' event.</summary>
        public const string DeletedCloudEventType = "google.cloud.firestore.document.v1.deleted";

        /// <summary>CloudEvent type for the 'written' event.</summary>
        public const string WrittenCloudEventType = "google.cloud.firestore.document.v1.written";

        /// <summary>CloudEvent type for the 'created.withAuthContext' event.</summary>
        public const string CreatedWithAuthContextCloudEventType = "google.cloud.firestore.document.v1.created.withAuthContext";

        /// <summary>CloudEvent type for the 'updated.withAuthContext' event.</summary>
        public const string UpdatedWithAuthContextCloudEventType = "google.cloud.firestore.document.v1.updated.withAuthContext";

        /// <summary>CloudEvent type for the 'deleted.withAuthContext' event.</summary>
        public const string DeletedWithAuthContextCloudEventType = "google.cloud.firestore.document.v1.deleted.withAuthContext";

        /// <summary>CloudEvent type for the 'written.withAuthContext' event.</summary>
        public const string WrittenWithAuthContextCloudEventType = "google.cloud.firestore.document.v1.written.withAuthContext";

    }
}
