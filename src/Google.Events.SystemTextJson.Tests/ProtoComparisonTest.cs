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

using Google.Events.Protobuf;
using Google.Events.Protobuf.Cloud.Firestore.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using Xunit;
using BclType = System.Type;

namespace Google.Events.SystemTextJson.Tests
{
    /// <summary>
    /// Validates that every protobuf message has a corresponding class in the JSON
    /// world, with the same properties.
    /// </summary>
    public class ProtoComparisonTest
    {
        // Types that don't need to be mapped, e.g. because we're handling them better manually.
        private static BclType[] IgnoredTypes = 
        {
            typeof(Value),
            typeof(MapValue),
            typeof(ArrayValue)
        };

        // Annoyingly, we can't initialize TheoryData via LINQ
        public static TheoryData<BclType> AllProtobufTypes = GetAllProtobufTypes();

        private static TheoryData<BclType> GetAllProtobufTypes()
        {
            var types = typeof(ProtobufCloudEventDataConverter<>).Assembly.GetTypes()
                .Where(t => typeof(IMessage).IsAssignableFrom(t));
            var ret = new TheoryData<BclType>();
            foreach (var type in types.Except(IgnoredTypes))
            {
                ret.Add(type);
            }
            return ret;
        }

        [Theory]
        [MemberData(nameof(AllProtobufTypes))]
        public void ProtobufTypeHasJsonType(BclType protobufType) =>
            Assert.NotNull(GetJsonType(protobufType));

        [SkippableTheory]
        [MemberData(nameof(AllProtobufTypes))]
        public void JsonTypeHasProtobufProperties(BclType protobufType)
        {
            var jsonType = GetJsonType(protobufType);
            Skip.If(jsonType is null); // Already reported in ProtobufTypeHasJsonType
            var protoProperties = protobufType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => p.Name);
            var jsonProperties = jsonType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => p.Name);
            var missingProperties = protoProperties.Except(jsonProperties);
            Assert.Empty(missingProperties);
        }

        [SkippableTheory]
        [MemberData(nameof(AllProtobufTypes))]
        public void ProtobufTypesHaveJsonProperties(BclType protobufType)
        {
            var jsonType = GetJsonType(protobufType);
            Skip.If(jsonType is null); // Already reported in ProtobufTypeHasJsonType
            var protoProperties = protobufType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => p.Name);
            var jsonProperties = jsonType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(p => p.Name);
            var missingProperties = jsonProperties.Except(protoProperties);
            Assert.Empty(missingProperties);
        }

        [SkippableTheory]
        [MemberData(nameof(AllProtobufTypes))]
        public void DataConverterAttributesAppliedConsistently(BclType protobufType)
        {
            var jsonType = GetJsonType(protobufType);
            Skip.If(jsonType is null); // Already reported in ProtobufTypeHasJsonType
            Assert.Equal(
                protobufType.IsDefined(typeof(CloudEventDataConverterAttribute), false),
                jsonType.IsDefined(typeof(CloudEventDataConverterAttribute), false));
        }

        [SkippableTheory]
        [MemberData(nameof(AllProtobufTypes))]
        public void JsonPropertiesUseCorrectJsonAttributes(BclType protobufType)
        {
            var jsonType = GetJsonType(protobufType);
            Skip.If(jsonType is null); // Already reported in ProtobufTypeHasJsonType
            var descriptor = (MessageDescriptor) protobufType.GetProperty("Descriptor").GetValue(null);
            foreach (var property in protobufType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var jsonProperty = jsonType.GetProperty(property.Name);
                // Already reported in JsonTypeHasProtobufProperties
                if (jsonProperty is null)
                {
                    continue;
                }
                // Manual properties won't have a corresponding field number, and
                // we should have applied JsonIgnore to the JSON property.
                var fieldNumberConst = protobufType.GetField($"{property.Name}FieldNumber");
                if (fieldNumberConst is null)
                {
                    Assert.True(jsonProperty.IsDefined(typeof(JsonIgnoreAttribute), false));
                }
                else
                {
                    var fieldNumber = (int) fieldNumberConst.GetValue(null);
                    string expectedJsonName = descriptor.Fields[fieldNumber].JsonName;
                    var attribute = jsonProperty.GetCustomAttribute<JsonPropertyNameAttribute>();
                    Assert.NotNull(attribute);
                    Assert.Equal(expectedJsonName, attribute.Name);
                }
            }
        }

        private BclType GetJsonType(BclType protobufType)
        {
            // TODO: Handle nested types as if they're not nested.
            var ns = protobufType.Namespace.Replace("Google.Events.Protobuf", "Google.Events.SystemTextJson");
            // "Unnest" types, e.g. StorageObjectData.Types.CustomerEncryption to just CustomerEncryption
            var name = protobufType.Name.Split('+').Last();
            var expectedType = $"{ns}.{name}";
            return typeof(JsonCloudEventDataConverter<>).Assembly.GetType(expectedType);
        }
    }
}
