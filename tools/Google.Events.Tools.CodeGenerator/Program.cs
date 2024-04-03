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
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
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
            string srcDirectory = args[1];

            var extensionRegistry = new ExtensionRegistry
            {
                CloudeventExtensions.CloudEventType,
                CloudeventExtensions.CloudEventProduct,
                CloudeventExtensions.CloudEventExtensionAttribute,
                CloudeventExtensions.CloudEventExtensionName
            };
            var descriptorSet = FileDescriptorSet.Parser.WithExtensionRegistry(extensionRegistry).ParseFrom(File.ReadAllBytes(args[0]));

            var descriptorsByPackage = descriptorSet.File.GroupBy(fd => fd.Package);

            foreach (var group in descriptorsByPackage)
            {
                var cloudEvents = group.SelectMany(fd => fd.MessageType.Select(CloudEventInfo.FromMessage))
                    .OfType<CloudEventInfo>()
                    .ToList();
                var extensionAttributes = group.SelectMany(fd => fd.Options?.GetExtension(CloudeventExtensions.CloudEventExtensionAttribute) ?? Enumerable.Empty<ExtensionAttribute>())
                    .ToList();
                var csharpNamespace = group.First().Options.CsharpNamespace;

                GenerateCode(srcDirectory, "Google.Events.Protobuf", csharpNamespace, "ProtobufJsonCloudEventFormatter", cloudEvents, extensionAttributes);
            }
            return 0;
        }

        /// <summary>
        /// Generates all the code for the CloudEvents in a single proto package.
        /// </summary>
        /// <param name="srcDirectory">The root source directory in the repo.</param>
        /// <param name="project">The name of the project to generate code in.</param>
        /// <param name="protoCSharpNamespace">The C# namespace specified as options in the proto files.</param>
        /// <param name="formatter">The CloudEventFormatter type to specify</param>
        /// <param name="events">The CloudEvents in this package.</param>
        /// <param name="extensionAttributes">The extension attributes in this package.</param>
        private static void GenerateCode(string srcDirectory, string project, string protoCSharpNamespace, string formatter, IEnumerable<CloudEventInfo> events, IEnumerable<ExtensionAttribute> extensionAttributes)
        {
            var projectDirectory = Path.Combine(srcDirectory, project);
            var trailingNamespace = protoCSharpNamespace.Replace("Google.Events.Protobuf.", "");
            string directory = Path.Combine(projectDirectory, trailingNamespace.Replace('.', '/'));
            Directory.CreateDirectory(directory);
            var packageNamespace = $"{project}.{trailingNamespace}";
            GenerateCloudEventTypes();
            GenerateExtensionAttributes();

            void GenerateCloudEventTypes()
            {
                foreach (var group in events.GroupBy(evt => evt.DataMessage))
                {
                    string messageName = group.Key;
                    var file = Path.Combine(directory, $"{messageName}.g.cs");

                    using (var writer = File.CreateText(file))
                    {
                        WriteCopyright(writer);
                        writer.WriteLine();
                        writer.WriteLine($"namespace {packageNamespace}");
                        writer.WriteLine("{    ");
                        writer.WriteLine($"    [global::CloudNative.CloudEvents.CloudEventFormatterAttribute(typeof({formatter}<{messageName}>))]");
                        writer.WriteLine($"    public partial class {messageName}");
                        writer.WriteLine("    {");
                        foreach (var type in group.Select(ce => ce.Type))
                        {
                            // Firestore and Datastore have separate "withAuthContext" variants; in those cases we want to
                            // use the previous segment as well. Hard-coding this isn't pleasant, but it'll do until we see
                            // anything else we need to do.
                            var suffix = type
                                .Replace(".withAuthContext", "WithAuthContext")
                                .Split('.')
                                .Last();
                            // "Undo" the hack before to get back to the relevant part of the type.
                            // (We can't just use type.Split('.').Last(), as that would just give us "withAuthContext".)
                            var description = suffix.Replace("WithAuthContext", ".withAuthContext");
                            var constantName = char.ToUpperInvariant(suffix[0]) + suffix[1..];
                            writer.WriteLine($"        /// <summary>CloudEvent type for the '{description}' event.</summary>");
                            writer.WriteLine($"        public const string {constantName}CloudEventType = \"{type}\";");
                            writer.WriteLine();
                        }
                        writer.WriteLine("    }");
                        writer.WriteLine("}");
                    }
                }
            }

            void GenerateExtensionAttributes()
            {
                if (!extensionAttributes.Any())
                {
                    return;
                }

                var pairs = extensionAttributes
                    .Select(attr => (attribute: attr, events: events.Where(ev => ev.ExtensionAttributes.Contains(attr.Name)).ToList()))
                    .OrderBy(attr => attr.attribute.Name)
                    .ToList();

                var file = Path.Combine(directory, "ExtensionAttributes.g.cs");
                using (var writer = File.CreateText(file))
                {
                    WriteCopyright(writer);
                    writer.WriteLine();
                    writer.WriteLine("using CloudNative.CloudEvents;");
                    writer.WriteLine();
                    writer.WriteLine($"namespace {packageNamespace}");
                    writer.WriteLine("{    ");
                    writer.WriteLine($"    /// <summary>Extension attributes for {packageNamespace} events.</summary>");
                    writer.WriteLine("    public static class ExtensionAttributes");
                    writer.WriteLine("    {");
                    foreach (var (attribute, eventsUsingAttribute) in pairs)
                    {
                        var camelCaseName = attribute.CamelCaseName == "" ? attribute.Name : attribute.CamelCaseName;
                        var propertyName = char.ToUpperInvariant(camelCaseName[0]) + camelCaseName[1..];
                        writer.WriteLine($"        /// <summary>");
                        writer.WriteLine($"        /// <para>{attribute.Description}</para>");

                        // Some extension attributes (e.g. for Firebase Database events) don't specify which
                        // events they'll be present on. It's still better to generate them than not though.
                        if (eventsUsingAttribute.Any())
                        {
                            writer.WriteLine($"        ///");
                            writer.WriteLine($"        /// <para>This is used by the following events:</para>");
                            writer.WriteLine($"        ///");
                            writer.WriteLine($"        /// <list type=\"bullet\">");
                            foreach (var evt in eventsUsingAttribute)
                            {
                                writer.WriteLine($"        ///   <item><description>{evt.Type}</description></item>");
                            }
                            writer.WriteLine($"        /// </list>");
                        }
                        writer.WriteLine($"        /// </summary>");
                        writer.WriteLine($"        public static CloudEventAttribute {propertyName} {{ get; }} = CloudEventAttribute.CreateExtension(\"{attribute.Name}\", CloudEventAttributeType.String);");
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
