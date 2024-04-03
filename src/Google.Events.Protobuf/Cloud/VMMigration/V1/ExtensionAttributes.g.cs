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

namespace Google.Events.Protobuf.Cloud.VMMigration.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.VMMigration.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the CloneJob triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.cloneJob.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CloneJob { get; } = CloudEventAttribute.CreateExtension("clonejob", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the CutoverJob triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.cutoverJob.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CutoverJob { get; } = CloudEventAttribute.CreateExtension("cutoverjob", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DatacenterConnector triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.datacenterConnector.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.datacenterConnector.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DatacenterConnector { get; } = CloudEventAttribute.CreateExtension("datacenterconnector", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Group triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.group.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.group.v1.updated</description></item>
        ///   <item><description>google.cloud.vmmigration.group.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Group { get; } = CloudEventAttribute.CreateExtension("group", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the MigratingVm triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.updated</description></item>
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.deleted</description></item>
        ///   <item><description>google.cloud.vmmigration.cloneJob.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.cutoverJob.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute MigratingVm { get; } = CloudEventAttribute.CreateExtension("migratingvm", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Source triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.source.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.source.v1.updated</description></item>
        ///   <item><description>google.cloud.vmmigration.source.v1.deleted</description></item>
        ///   <item><description>google.cloud.vmmigration.utilizationReport.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.utilizationReport.v1.deleted</description></item>
        ///   <item><description>google.cloud.vmmigration.datacenterConnector.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.datacenterConnector.v1.deleted</description></item>
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.updated</description></item>
        ///   <item><description>google.cloud.vmmigration.migratingVm.v1.deleted</description></item>
        ///   <item><description>google.cloud.vmmigration.cloneJob.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.cutoverJob.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute SourceId { get; } = CloudEventAttribute.CreateExtension("sourceid", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the TargetProject triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.targetProject.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.targetProject.v1.updated</description></item>
        ///   <item><description>google.cloud.vmmigration.targetProject.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute TargetProject { get; } = CloudEventAttribute.CreateExtension("targetproject", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the UtilizationReport triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.vmmigration.utilizationReport.v1.created</description></item>
        ///   <item><description>google.cloud.vmmigration.utilizationReport.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute UtilizationReport { get; } = CloudEventAttribute.CreateExtension("utilizationreport", CloudEventAttributeType.String);

    }
}
