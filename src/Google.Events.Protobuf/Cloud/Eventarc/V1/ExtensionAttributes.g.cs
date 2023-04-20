// Copyright 2023, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Eventarc.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Eventarc.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Channel triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.eventarc.channel.v1.created</description></item>
        ///   <item><description>google.cloud.eventarc.channel.v1.updated</description></item>
        ///   <item><description>google.cloud.eventarc.channel.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Channel { get; } = CloudEventAttribute.CreateExtension("channel", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the ChannelConnection triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.eventarc.channelConnection.v1.created</description></item>
        ///   <item><description>google.cloud.eventarc.channelConnection.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute ChannelConnection { get; } = CloudEventAttribute.CreateExtension("channelconnection", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Trigger triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.eventarc.trigger.v1.created</description></item>
        ///   <item><description>google.cloud.eventarc.trigger.v1.updated</description></item>
        ///   <item><description>google.cloud.eventarc.trigger.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Trigger { get; } = CloudEventAttribute.CreateExtension("trigger", CloudEventAttributeType.String);

    }
}
