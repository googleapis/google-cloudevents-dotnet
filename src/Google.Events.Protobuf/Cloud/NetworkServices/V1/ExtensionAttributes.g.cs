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

namespace Google.Events.Protobuf.Cloud.NetworkServices.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.NetworkServices.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the EndpointPolicy triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.endpointPolicy.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.endpointPolicy.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.endpointPolicy.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute EndpointPolicy { get; } = CloudEventAttribute.CreateExtension("endpointpolicy", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Gateway triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.gateway.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.gateway.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.gateway.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Gateway { get; } = CloudEventAttribute.CreateExtension("gateway", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the GrpcRoute triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.grpcRoute.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.grpcRoute.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.grpcRoute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute GrpcRoute { get; } = CloudEventAttribute.CreateExtension("grpcroute", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the HttpRoute triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.httpRoute.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.httpRoute.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.httpRoute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute HttpRoute { get; } = CloudEventAttribute.CreateExtension("httproute", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Mesh triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.mesh.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.mesh.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.mesh.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Mesh { get; } = CloudEventAttribute.CreateExtension("mesh", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ServiceBinding triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.serviceBinding.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.serviceBinding.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceBinding { get; } = CloudEventAttribute.CreateExtension("servicebinding", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the TcpRoute triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.tcpRoute.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.tcpRoute.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.tcpRoute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute TcpRoute { get; } = CloudEventAttribute.CreateExtension("tcproute", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the TlsRoute triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.networkservices.tlsRoute.v1.created</description></item>
        ///   <item><description>google.cloud.networkservices.tlsRoute.v1.updated</description></item>
        ///   <item><description>google.cloud.networkservices.tlsRoute.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute TlsRoute { get; } = CloudEventAttribute.CreateExtension("tlsroute", CloudEventAttributeType.String);

    }
}
