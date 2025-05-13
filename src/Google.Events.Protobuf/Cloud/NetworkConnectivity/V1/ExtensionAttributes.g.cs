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

namespace Google.Events.Protobuf.Cloud.NetworkConnectivity.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.NetworkConnectivity.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Hub triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.hub.v1.created</description></item>
        ///   <item><description>google.cloud.networkconnectivity.hub.v1.updated</description></item>
        ///   <item><description>google.cloud.networkconnectivity.hub.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Hub { get; } = CloudEventAttribute.CreateExtension("hub", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ServiceClass triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.serviceClass.v1.updated</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceClass.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceClass { get; } = CloudEventAttribute.CreateExtension("serviceclass", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ServiceConnectionMap triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionMap.v1.created</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionMap.v1.updated</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionMap.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceConnectionMap { get; } = CloudEventAttribute.CreateExtension("serviceconnectionmap", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ServiceConnectionPolicy triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionPolicy.v1.created</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionPolicy.v1.updated</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionPolicy.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceConnectionPolicy { get; } = CloudEventAttribute.CreateExtension("serviceconnectionpolicy", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ServiceConnectionToken triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionToken.v1.created</description></item>
        ///   <item><description>google.cloud.networkconnectivity.serviceConnectionToken.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceConnectionToken { get; } = CloudEventAttribute.CreateExtension("serviceconnectiontoken", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Spoke triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkconnectivity.spoke.v1.created</description></item>
        ///   <item><description>google.cloud.networkconnectivity.spoke.v1.updated</description></item>
        ///   <item><description>google.cloud.networkconnectivity.spoke.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Spoke { get; } = CloudEventAttribute.CreateExtension("spoke", CloudEventAttributeType.String);

    }
}
