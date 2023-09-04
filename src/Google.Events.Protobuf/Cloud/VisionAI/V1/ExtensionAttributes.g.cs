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

namespace Google.Events.Protobuf.Cloud.VisionAI.V1
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.VisionAI.V1 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Analysis triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.analysis.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.analysis.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.analysis.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Analysis { get; } = CloudEventAttribute.CreateExtension("analysis", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Application triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.application.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.application.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.application.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.draft.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.draft.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.draft.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Application { get; } = CloudEventAttribute.CreateExtension("application", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Cluster triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.analysis.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.analysis.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.analysis.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.process.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.process.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.process.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.cluster.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.cluster.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.cluster.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.stream.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.stream.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.stream.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.event.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.event.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.event.v1.deleted</description></item>
        ///   <item><description>google.cloud.visionai.series.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.series.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.series.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Cluster { get; } = CloudEventAttribute.CreateExtension("cluster", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Draft triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.draft.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.draft.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.draft.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Draft { get; } = CloudEventAttribute.CreateExtension("draft", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Event triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.event.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.event.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.event.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Event { get; } = CloudEventAttribute.CreateExtension("event", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Process triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.process.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.process.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.process.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Process { get; } = CloudEventAttribute.CreateExtension("process", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Processor triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.processor.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.processor.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.processor.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Processor { get; } = CloudEventAttribute.CreateExtension("processor", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Series triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.series.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.series.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.series.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Series { get; } = CloudEventAttribute.CreateExtension("series", CloudEventAttributeType.String);

        /// <summary>
        /// <para>The resource ID of the Stream triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.visionai.stream.v1.created</description></item>
        ///   <item><description>google.cloud.visionai.stream.v1.updated</description></item>
        ///   <item><description>google.cloud.visionai.stream.v1.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Stream { get; } = CloudEventAttribute.CreateExtension("stream", CloudEventAttributeType.String);

    }
}
