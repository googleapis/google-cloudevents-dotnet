#!/bin/bash

# Script to generate code from https://github.com/googleapis/google-cloudevents:
# - Classes from Protobuf messages (as per the regular C# generator)
# - Attributes to specify CloudEvent converters
# - CloudEvent type constants
#
# Note that the attributes and CloudEvent type constants are generated for
# all supported serialization formats.

set -e

echo "~ START"
PROTOBUF_VERSION=21.6

# protoc is a native application, so we need to download different zip files
# and use different binaries depending on the OS.
echo "- Determining OS type"
case "$OSTYPE" in
  linux*)
    PROTOBUF_PLATFORM=linux-x86_64
    PROTOC=tmp/protobuf/bin/protoc
    ;;
  win* | msys* | cygwin*)
    PROTOBUF_PLATFORM=win64
    PROTOC=tmp/protobuf/bin/protoc.exe
    ;;
  darwin*)
    PROTOBUF_PLATFORM=osx-x86_64
    PROTOC=tmp/protobuf/bin/protoc
    ;;    
  *)
    echo "Unknown OSTYPE: $OSTYPE"
    exit 1
esac

echo "- Cloning github.com/googleapis/google-cloudevents into tmp"
# For the moment, just clone google-cloudevents. Later we might make
# it a submodule. We clone quietly, and only with a depth of 1
# as we don't need history.
rm -rf tmp
mkdir tmp
git clone https://github.com/googleapis/google-cloudevents tmp/google-cloudevents -q --depth 1

# We download a specific version rather than using package managers
# for portability and being able to rely on the version being available
# as soon as it's released on GitHub.
echo "- Downloading protobuf tools"
cd tmp
curl -sSL \
  https://github.com/protocolbuffers/protobuf/releases/download/v$PROTOBUF_VERSION/protoc-$PROTOBUF_VERSION-$PROTOBUF_PLATFORM.zip \
  --output protobuf.zip
(mkdir protobuf && cd protobuf && unzip -q ../protobuf.zip)
cd ..
chmod +x $PROTOC

echo "- Generating src/Google.Events.Protobuf"

# First delete any previously-generated files
rm -f $(find src/Google.Events.Protobuf -name '*.g.cs')

# Generate the C# messages, just for data protos

# Explanation of flags:
# --csharp_out=...
#   We're generating C#
# --csharp_opt=base_namespace=Google.Events.Protobuf
#   Controls how directories are generated (C#-specific)
# --csharp_opt=file_extension=.g.cs
#   Controls the extension of generated files (C# specific)
# -I tmp/protobuf/include
#   Make the google.protobuf protos available (e.g. google.protobuf.Timestamp)
# -I tmp/google-cloud-events/third_party/googleapis
#   Make the common API-related protos available (e.g. google.type.Date)
# -I tmp/google-cloud-events/proto
#   Make the CloudEvent protos themselves available (these are the ones we generate)
# $(find tmp/google-cloudevents/proto -name data.proto)
#   Specifies the protos we want to generate - just the event data messages

echo "- Generating C# from protobuf messages"
$PROTOC \
  --csharp_out=src/Google.Events.Protobuf \
  --csharp_opt=base_namespace=Google.Events.Protobuf \
  --csharp_opt=file_extension=.g.cs \
  -I tmp/protobuf/include \
  -I tmp/google-cloudevents/third_party/googleapis \
  -I tmp/google-cloudevents/proto \
  $(find tmp/google-cloudevents/proto -name data.proto)

# protoc doesn't include a copyright message. Add it here.

echo "- Adding copyright to generated code"
cat > tmp/copyright.txt <<END_OF_COPYRIGHT
// Copyright $(date +%Y), Google LLC
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

END_OF_COPYRIGHT

for generated in $(find src/Google.Events.Protobuf -name '*.g.cs')
do
  cat tmp/copyright.txt $generated > tmp/with-copyright
  mv tmp/with-copyright $generated
done

# Create a protobuf descriptor set, which we can use to extract the CloudEvent
# types from annotations.

echo "- Compiling protobuf descriptor set"
$PROTOC \
  --descriptor_set_out=tmp/protos.pb \
  -I tmp/protobuf/include \
  -I tmp/google-cloudevents/third_party/googleapis \
  -I tmp/google-cloudevents/proto \
  $(find tmp/google-cloudevents/proto -name '*.proto')

# Run code generation from the descriptor set

echo "- Generating additional code from descriptor set"
dotnet run --project tools/Google.Events.Tools.CodeGenerator -- tmp/protos.pb src

echo "- Removing tmp/"
rm -rf tmp
echo "~ DONE ✓"
