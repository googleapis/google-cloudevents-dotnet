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

namespace Google.Events.Protobuf.Cloud.Metastore.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Metastore.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Backup triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.metastore.backup.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.backup.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Backup { get; } = CloudEventAttribute.CreateExtension("backup", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Federation triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.metastore.federation.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.federation.v1.updated</description></item>
        ///   <item><description>google.cloud.metastore.federation.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Federation { get; } = CloudEventAttribute.CreateExtension("federation", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the MetadataImport triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.metastore.metadataImport.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.metadataImport.v1.updated</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute MetadataImport { get; } = CloudEventAttribute.CreateExtension("metadataimport", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Service triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.metastore.service.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.service.v1.updated</description></item>
        ///   <item><description>google.cloud.metastore.service.v1.deleted</description></item>
        ///   <item><description>google.cloud.metastore.metadataImport.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.metadataImport.v1.updated</description></item>
        ///   <item><description>google.cloud.metastore.backup.v1.created</description></item>
        ///   <item><description>google.cloud.metastore.backup.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Service { get; } = CloudEventAttribute.CreateExtension("service", CloudEventAttributeType.String);

    }
}
