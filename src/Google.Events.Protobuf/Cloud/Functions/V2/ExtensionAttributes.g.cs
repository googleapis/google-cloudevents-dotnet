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

namespace Google.Events.Protobuf.Cloud.Functions.V2
{    
    /// <summary>Extension attributes for Google.Events.Protobuf.Cloud.Functions.V2 events.</summary>
    public static class ExtensionAttributes
    {
        /// <summary>
        /// <para>The resource ID of the Function triggering the event.</para>
        ///
        /// <para>This is used by the following events:</para>
        ///
        /// <list type="bullet">
        ///   <item><description>google.cloud.functions.function.v2.created</description></item>
        ///   <item><description>google.cloud.functions.function.v2.updated</description></item>
        ///   <item><description>google.cloud.functions.function.v2.deleted</description></item>
        /// </list>
        /// </summary>
        public static CloudEventAttribute Function { get; } = CloudEventAttribute.CreateExtension("function", CloudEventAttributeType.String);

    }
}
