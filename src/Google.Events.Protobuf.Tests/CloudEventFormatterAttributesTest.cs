﻿// Copyright 2021, Google LLC
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
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Events.Protobuf.Tests
{
    public class CloudEventFormatterAttributesTest
    {
        [Fact]
        public void CloudEventConvertersAppliedToSelf()
        {
            var pairs = typeof(ProtobufJsonCloudEventFormatter<>).Assembly.GetTypes()
                .Where(t => t.IsDefined(typeof(CloudEventFormatterAttribute)))
                .Select(t => (messageType: t, converter: t.GetCustomAttribute<CloudEventFormatterAttribute>().FormatterType))
                .ToList();

            Assert.All(pairs, pair =>
            {
                var messageType = pair.messageType;
                var expectedConverter = typeof(ProtobufJsonCloudEventFormatter<>).MakeGenericType(new[] { messageType });
                Assert.Equal(expectedConverter, pair.converter);
            });
        }
    }
}
