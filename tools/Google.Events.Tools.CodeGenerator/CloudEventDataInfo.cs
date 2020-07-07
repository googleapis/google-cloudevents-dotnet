// Copyright 2020, Google LLC
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

using System.Collections.Generic;

namespace Google.Events.Tools.CodeGenerator
{
    internal sealed class CloudEventDataInfo
    {
        public string MessageName { get; }
        public string ProtobufNamespace { get; }
        public List<string> CloudEventTypes { get; } = new List<string>();

        public CloudEventDataInfo(string messageName, string protobufNamespace) =>
            (MessageName, ProtobufNamespace) = (messageName, protobufNamespace);
    }
}
