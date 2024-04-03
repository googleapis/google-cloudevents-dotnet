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

namespace Google.Events.Protobuf.Cloud.Dataplex.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Dataplex.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Asset triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.asset.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Asset { get; } = CloudEventAttribute.CreateExtension("asset", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DataAttributeBindingId triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.dataAttributeBinding.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttributeBinding.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttributeBinding.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DataAttributeBindingId { get; } = CloudEventAttribute.CreateExtension("dataattributebindingid", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DataAttributeId triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DataAttributeId { get; } = CloudEventAttribute.CreateExtension("dataattributeid", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Datascan triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.dataScan.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.dataScan.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.dataScan.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Datascan { get; } = CloudEventAttribute.CreateExtension("datascan", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Datataxonomy triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.dataAttribute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Datataxonomy { get; } = CloudEventAttribute.CreateExtension("datataxonomy", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DataTaxonomyId triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.dataTaxonomy.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.dataTaxonomy.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.dataTaxonomy.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DataTaxonomyId { get; } = CloudEventAttribute.CreateExtension("datataxonomyid", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Environment triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.environment.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.environment.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.environment.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Environment { get; } = CloudEventAttribute.CreateExtension("environment", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Lake triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.lake.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.lake.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.lake.v1.deleted</description></item>
        ///   <item><description>google.cloud.dataplex.zone.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.zone.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.zone.v1.deleted</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.deleted</description></item>
        ///   <item><description>google.cloud.dataplex.task.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.task.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.task.v1.deleted</description></item>
        ///   <item><description>google.cloud.dataplex.environment.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.environment.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.environment.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Lake { get; } = CloudEventAttribute.CreateExtension("lake", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Task triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.task.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.task.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.task.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Task { get; } = CloudEventAttribute.CreateExtension("task", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Zone triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.dataplex.zone.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.zone.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.zone.v1.deleted</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.created</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.updated</description></item>
        ///   <item><description>google.cloud.dataplex.asset.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Zone { get; } = CloudEventAttribute.CreateExtension("zone", CloudEventAttributeType.String);

    }
}
