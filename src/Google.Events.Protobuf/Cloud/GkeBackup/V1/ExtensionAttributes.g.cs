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

using CloudNative.CloudEvents;

namespace Google.Events.Protobuf.Cloud.GkeBackup.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.GkeBackup.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Backup triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.gkebackup.backup.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.backup.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.backup.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Backup { get; } = CloudEventAttribute.CreateExtension("backup", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the BackupPlan triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.gkebackup.backupPlan.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.backupPlan.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.backupPlan.v1.deleted</description></item>
        ///   <item><description>google.cloud.gkebackup.backup.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.backup.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.backup.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute BackupPlan { get; } = CloudEventAttribute.CreateExtension("backupplan", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Restore triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.gkebackup.restore.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.restore.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.restore.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Restore { get; } = CloudEventAttribute.CreateExtension("restore", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the RestorePlan triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.gkebackup.restorePlan.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.restorePlan.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.restorePlan.v1.deleted</description></item>
        ///   <item><description>google.cloud.gkebackup.restore.v1.created</description></item>
        ///   <item><description>google.cloud.gkebackup.restore.v1.updated</description></item>
        ///   <item><description>google.cloud.gkebackup.restore.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute RestorePlan { get; } = CloudEventAttribute.CreateExtension("restoreplan", CloudEventAttributeType.String);

    }
}
