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

namespace Google.Events.Protobuf.Cloud.Firestore.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Firestore.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The Firestore database name. The default database name is "(default)".</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.firestore.document.v1.created</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.updated</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.deleted</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Database { get; } = CloudEventAttribute.CreateExtension("database", CloudEventAttributeType.String);

        /// <summary>
        /// <para>Pattern to match for the resource.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.firestore.document.v1.created</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.updated</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.deleted</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Document { get; } = CloudEventAttribute.CreateExtension("document", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The Firestore database namespace. Applicable to database instances running in Datastore mode only. The default namespace is "(default)".</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.firestore.document.v1.created</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.updated</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.deleted</description></item>
        ///   <item><description>google.cloud.firestore.document.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Namespace { get; } = CloudEventAttribute.CreateExtension("namespace", CloudEventAttributeType.String);

    }
}
