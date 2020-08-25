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

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Events.Tools.CodeGenerator
{
    /// <summary>
    /// Code generator for everything that protoc can't handle directly.
    /// (This could potentially be a protoc plugin instead, but this is probably simpler.)
    /// </summary>
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine($"Required arguments: <path to protobuf descriptor set> <src directory to generate in>");
                return 1;
            }

            string descriptorSetFile = args[0];
            string srcDirectory = args[1];

            var info = LoadCloudEventDataInfo(descriptorSetFile);

            GenerateCode(info, srcDirectory, "Google.Events.Protobuf", "ProtobufCloudEventDataConverter");
            return 0;
        }

        /// <summary>
        /// Loads the specified descriptor set, and extracts CloudEvent information from it.
        /// </summary>
        private static List<CloudEventDataInfo> LoadCloudEventDataInfo(string file)
        {
            // Note: while it's slightly annoying to hard-code this, it's less annoying than loading the
            // descriptor set without extensions, finding the extension number, and then reloading it.
            const int extensionField = 11716486;
            var fieldCodec = FieldCodec.ForString(WireFormat.MakeTag(extensionField, WireFormat.WireType.LengthDelimited), "");
            var extension = new Extension<MessageOptions, string>(extensionField, fieldCodec);
            var extensionRegistry = new ExtensionRegistry { extension };

            var descriptorSetBytes = File.ReadAllBytes(file);
            var descriptorSet = FileDescriptorSet.Parser.WithExtensionRegistry(extensionRegistry).ParseFrom(descriptorSetBytes);

            var typeToNamespace = (from protoFile in descriptorSet.File
                                   from message in protoFile.MessageType
                                   select (protoFile, message))
                                   .ToDictionary(pair => $"{pair.protoFile.Package}.{pair.message.Name}", pair => pair.protoFile.Options.CsharpNamespace);

            // ConcurrentDictionary has a convenient GetOrAdd method.
            ConcurrentDictionary<string, CloudEventDataInfo> infoByFqn = new ConcurrentDictionary<string, CloudEventDataInfo>();

            // Find every message in every file in the descriptor set, and check for the cloud_event_type extension.
            // If it has one, check for a field called "data" and take the type of that, then create a CloudEventDataInfo
            // that knows the C# namespace of the message, the message name, and the CloudEvent type.
            foreach (var protoFile in descriptorSet.File)
            {
                var package = protoFile.Package;
                foreach (var message in protoFile.MessageType)
                {
                    var eventType = message.Options?.GetExtension(extension);
                    if (string.IsNullOrWhiteSpace(eventType))
                    {
                        continue;
                    }
                    // We expect each CloudEvent message to have a data field, which is a message.
                    var dataFieldType = message.Field.Single(f => f.Name == "data").TypeName;
                    // Convert the type to a fully-qualified name
                    var fqn = dataFieldType.StartsWith(".") ? dataFieldType.Substring(1) : $"{package}.{dataFieldType}";
                    var messageName = fqn.Split('.').Last();
                    CloudEventDataInfo info = infoByFqn.GetOrAdd(fqn, _ => new CloudEventDataInfo(messageName, typeToNamespace[fqn]));
                    info.CloudEventTypes.Add(eventType);
                }
            }
            return infoByFqn.Values.ToList();
        }

        private static void GenerateCode(IEnumerable<CloudEventDataInfo> infos, string srcDirectory, string project, string converter)
        {
            var projectDirectory = Path.Combine(srcDirectory, project);
            foreach (var info in infos)
            {
                var trailingNamespace = info.ProtobufNamespace.Replace("Google.Events.Protobuf.", "");
                var fileNamespace = $"{project}.{trailingNamespace}";
                var file = Path.Combine(projectDirectory, trailingNamespace.Replace('.', '/'), $"{info.MessageName}.g.cs");

                using (var writer = File.CreateText(file))
                {
                    WriteCopyright(writer);
                    writer.WriteLine();
                    writer.WriteLine($"namespace {fileNamespace}");
                    writer.WriteLine("{    ");
                    writer.WriteLine($"    [CloudEventDataConverter(typeof({converter}<{info.MessageName}>))]");
                    writer.WriteLine($"    public partial class {info.MessageName}");
                    writer.WriteLine("    {");
                    foreach (var type in info.CloudEventTypes)
                    {
                        var suffix = type.Split('.').Last();
                        var constantName = char.ToUpperInvariant(suffix[0]) + suffix[1..];
                        writer.WriteLine($"        /// <summary>CloudEvent type for the '{suffix}' event.</summary>");
                        writer.WriteLine($"        public const string {constantName}CloudEventType = \"{type}\";");
                        writer.WriteLine();
                    }
                    writer.WriteLine("    }");
                    writer.WriteLine("}");
                }
            }
        }

        private static void WriteCopyright(TextWriter writer)
        {
            writer.WriteLine($"// Copyright {DateTime.UtcNow.Year}, Google LLC");
            writer.WriteLine("//");
            writer.WriteLine("// Licensed under the Apache License, Version 2.0 (the \"License\");");
            writer.WriteLine("// you may not use this file except in compliance with the License.");
            writer.WriteLine("// You may obtain a copy of the License at");
            writer.WriteLine("//");
            writer.WriteLine("//     https://www.apache.org/licenses/LICENSE-2.0");
            writer.WriteLine("//");
            writer.WriteLine("// Unless required by applicable law or agreed to in writing, software");
            writer.WriteLine("// distributed under the License is distributed on an \"AS IS\" BASIS,");
            writer.WriteLine("// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.");
            writer.WriteLine("// See the License for the specific language governing permissions and");
            writer.WriteLine("// limitations under the License.");
        }
    }
}
