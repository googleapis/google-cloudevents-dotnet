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

using CloudNative.CloudEvents;

namespace Google.Events.Protobuf.Firebase.Database.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Firebase.Database.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The Firebase Realtime Database domain of the source database.</para>
        /// </summary>
        public static CloudEventAttribute FirebaseDatabaseHost { get; } = CloudEventAttribute.CreateExtension("firebasedatabasehost", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The Firebase Realtime Database instance from which the event was triggered.</para>
        /// </summary>
        public static CloudEventAttribute Instance { get; } = CloudEventAttribute.CreateExtension("instance", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The Firebase Realtime Database path for which the event was triggered.</para>
        /// </summary>
        public static CloudEventAttribute Ref { get; } = CloudEventAttribute.CreateExtension("ref", CloudEventAttributeType.String);

    }
}
