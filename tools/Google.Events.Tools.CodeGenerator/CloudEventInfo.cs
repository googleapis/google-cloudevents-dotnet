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

using Google.Events.Protobuf;
using Google.Protobuf.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Google.Events.Tools.CodeGenerator;

/// <summary>
/// All the information about a single event. This is derived from the message information,
/// conventionally provided in events.proto.
/// </summary>
/// <param name="Type">The CloudEvent type, e.g. "google.cloud.audit.log.v1.written".</param>
/// <param name="DataMessageName">The name of the message specified by the data field.</param>
/// <param name="ExtensionAttributes">The extension attributes used by this CloudEvent.</param>
public record CloudEventInfo(string Type, string DataMessage, IReadOnlyList<string> ExtensionAttributes)
{
    /// <summary>
    /// Returns the CloudEvent information represented by the given message descriptor,
    /// or null if the message does not contain CloudEvent information.
    /// </summary>
    public static CloudEventInfo FromMessage(DescriptorProto message)
    {
        var type = message.Options?.GetExtension(CloudeventExtensions.CloudEventType);
        if (string.IsNullOrEmpty(type))
        {
            return null;
        }
        // We expect each CloudEvent message to have a data field, which is a message.
        var dataFieldType = message.Field.Single(f => f.Name == "data");
        var messageName = dataFieldType.TypeName.Split('.').Last();

        var attributes = (message.Options.GetExtension(CloudeventExtensions.CloudEventExtensionName) ?? Enumerable.Empty<string>())
            .ToList().AsReadOnly();
        return new CloudEventInfo(type, messageName, attributes);
    }
}
