#!/bin/bash

set -e

# Script to generate the Protobuf classes from google-cloudevents

PROTOBUF_VERSION=3.12.3

# protoc is a native application, so we need to download different zip files
# and use different binaries depending on the OS.
case "$OSTYPE" in
  linux*)
    PROTOBUF_PLATFORM=linux-x64_64
    PROTOC=tmp/protobuf/bin/protoc
    ;;
  win* | msys* | cygwin*)
    PROTOBUF_PLATFORM=win64
    PROTOC=tmp/protobuf/bin/protoc.exe
    ;;
  *)
    echo "Unknown OSTYPE: $OSTYPE"
    exit 1
esac

echo "Cloning google-cloudevents"
# For the moment, just clone google-cloudevents. Later we might make
# it a submodule. We clone quietly, and only with a depth of 1
# as we don't need history.
rm -rf tmp
mkdir tmp
git clone https://github.com/googleapis/google-cloudevents tmp/google-cloudevents -q --depth 1

# We download a specific version rather than using package managers
# for portability and being able to rely on the version being available
# as soon as it's released on GitHub.
echo "Downloading protobuf tools"
cd tmp
curl -sSL \
  https://github.com/protocolbuffers/protobuf/releases/download/v$PROTOBUF_VERSION/protoc-$PROTOBUF_VERSION-$PROTOBUF_PLATFORM.zip \
  --output protobuf.zip
(mkdir protobuf && cd protobuf && unzip -q ../protobuf.zip)
cd ..
chmod +x $PROTOC

echo "Generating"

# First delete any previously-generated files
rm -f $(find src/Google.Events.Protobuf -name '*.g.cs')

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

$PROTOC \
  --csharp_out=src/Google.Events.Protobuf \
  --csharp_opt=base_namespace=Google.Events.Protobuf \
  --csharp_opt=file_extension=.g.cs \
  -I tmp/protobuf/include \
  -I tmp/google-cloudevents/third_party/googleapis \
  -I tmp/google-cloudevents/proto \
  $(find tmp/google-cloudevents/proto -name data.proto)

echo "Done"
