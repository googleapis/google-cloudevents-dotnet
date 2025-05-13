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

namespace Google.Events.Protobuf.Cloud.ApiHub.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.ApiHub.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Api triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.api.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.api.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.api.v1.deleted</description></item>
        ///   <item><description>google.cloud.apihub.version.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.version.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.version.v1.deleted</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Api { get; } = CloudEventAttribute.CreateExtension("api", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ApiHubInstance triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.apiHubInstance.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ApiHubInstance { get; } = CloudEventAttribute.CreateExtension("apihubinstance", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Attribute triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.attribute.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Attribute { get; } = CloudEventAttribute.CreateExtension("attribute", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Dependency triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.dependency.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.dependency.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.dependency.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Dependency { get; } = CloudEventAttribute.CreateExtension("dependency", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Deployment triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.deployment.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.deployment.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.deployment.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Deployment { get; } = CloudEventAttribute.CreateExtension("deployment", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ExternalApi triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.externalApi.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.externalApi.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.externalApi.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ExternalApi { get; } = CloudEventAttribute.CreateExtension("externalapi", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the HostProjectRegistration triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.hostProjectRegistration.v1.created</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute HostProjectRegistration { get; } = CloudEventAttribute.CreateExtension("hostprojectregistration", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the RuntimeProjectAttachment triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.runtimeProjectAttachment.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.runtimeProjectAttachment.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute RuntimeProjectAttachment { get; } = CloudEventAttribute.CreateExtension("runtimeprojectattachment", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Spec triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.spec.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Spec { get; } = CloudEventAttribute.CreateExtension("spec", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Version triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.apihub.version.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.version.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.version.v1.deleted</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.created</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.updated</description></item>
        ///   <item><description>google.cloud.apihub.spec.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Version { get; } = CloudEventAttribute.CreateExtension("version", CloudEventAttributeType.String);

    }
}
