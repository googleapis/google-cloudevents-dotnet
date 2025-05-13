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

namespace Google.Events.Protobuf.Cloud.CertificateManager.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.CertificateManager.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Certificate triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.certificatemanager.certificate.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificate.v1.updated</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificate.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Certificate { get; } = CloudEventAttribute.CreateExtension("certificate", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the CertificateIssuanceConfig triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.certificatemanager.certificateIssuanceConfig.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateIssuanceConfig.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CertificateIssuanceConfig { get; } = CloudEventAttribute.CreateExtension("certificateissuanceconfig", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the CertificateMap triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.certificatemanager.certificateMap.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMap.v1.updated</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMap.v1.deleted</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.updated</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CertificateMap { get; } = CloudEventAttribute.CreateExtension("certificatemap", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the CertificateMapEntry triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.updated</description></item>
        ///   <item><description>google.cloud.certificatemanager.certificateMapEntry.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute CertificateMapEntry { get; } = CloudEventAttribute.CreateExtension("certificatemapentry", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the DnsAuthorization triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.certificatemanager.dnsAuthorization.v1.created</description></item>
        ///   <item><description>google.cloud.certificatemanager.dnsAuthorization.v1.updated</description></item>
        ///   <item><description>google.cloud.certificatemanager.dnsAuthorization.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute DnsAuthorization { get; } = CloudEventAttribute.CreateExtension("dnsauthorization", CloudEventAttributeType.String);

    }
}
