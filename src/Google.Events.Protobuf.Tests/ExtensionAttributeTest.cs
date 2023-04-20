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

using Google.Events.Protobuf.Cloud.Functions.V2;
using Xunit;
using PubSubExtensions = Google.Events.Protobuf.Cloud.PubSub.V1.ExtensionAttributes;

namespace Google.Events.Protobuf.Tests;

public class ExtensionAttributeTest
{
    [Fact]
    public void ExtensionAttributeFromDeserializedEvent()
    {
        var bytes = TestResourceHelper.LoadBytes("structured-mode-body-with-extension.json");
        var formatter = new ProtobufJsonCloudEventFormatter<FunctionEventData>();
        var evt = formatter.DecodeStructuredModeMessage(bytes, null, null);
        Assert.Equal("sample-function", evt[ExtensionAttributes.Function]);
    }

    [Fact]
    public void MissingExtensionAttribute()
    {
        var bytes = TestResourceHelper.LoadBytes("structured-mode-body-with-extension.json");
        var formatter = new ProtobufJsonCloudEventFormatter<FunctionEventData>();
        var evt = formatter.DecodeStructuredModeMessage(bytes, null, null);
        // Using an extension attribute which isn't present (in this case because
        // it's to do with a completely different set of events) just results
        // in a null value.
        Assert.Null(evt[PubSubExtensions.Topic]);
    }
}
