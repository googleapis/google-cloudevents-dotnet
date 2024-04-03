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

namespace Google.Events.Protobuf.Cloud.Audit.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Audit.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The name of the method (RPC) triggering the Cloud Audit log entry.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.audit.log.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute MethodName { get; } = CloudEventAttribute.CreateExtension("methodname", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The name of the resource that is the subject of the Cloud Audit log entry.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.audit.log.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ResourceName { get; } = CloudEventAttribute.CreateExtension("resourcename", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The name of the service which triggered the Cloud Audit log entry.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.audit.log.v1.written</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ServiceName { get; } = CloudEventAttribute.CreateExtension("servicename", CloudEventAttributeType.String);

    }
}
