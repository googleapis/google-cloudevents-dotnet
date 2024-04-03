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

namespace Google.Events.Protobuf.Cloud.Deploy.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Deploy.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Automation triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.automation.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.automation.v1.updated</description></item>
        ///   <item><description>google.cloud.deploy.automation.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Automation { get; } = CloudEventAttribute.CreateExtension("automation", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the CustomTargetType triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.customTargetType.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.customTargetType.v1.updated</description></item>
        ///   <item><description>google.cloud.deploy.customTargetType.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CustomTargetType { get; } = CloudEventAttribute.CreateExtension("customtargettype", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DeliveryPipeline triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.deliveryPipeline.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.deliveryPipeline.v1.updated</description></item>
        ///   <item><description>google.cloud.deploy.deliveryPipeline.v1.deleted</description></item>
        ///   <item><description>google.cloud.deploy.release.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.rollout.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.automation.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.automation.v1.updated</description></item>
        ///   <item><description>google.cloud.deploy.automation.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DeliveryPipeline { get; } = CloudEventAttribute.CreateExtension("deliverypipeline", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Release triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.release.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.rollout.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Release { get; } = CloudEventAttribute.CreateExtension("release", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Rollout triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.rollout.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Rollout { get; } = CloudEventAttribute.CreateExtension("rollout", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Target triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.deploy.target.v1.created</description></item>
        ///   <item><description>google.cloud.deploy.target.v1.updated</description></item>
        ///   <item><description>google.cloud.deploy.target.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Target { get; } = CloudEventAttribute.CreateExtension("target", CloudEventAttributeType.String);

    }
}
