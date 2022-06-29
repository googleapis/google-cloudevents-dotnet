#!/bin/bash

# Validation script, expected to be used during CI for
# google-cloudevents, as well as for local development.
# This script is used to validate that the protobuf schema
# representation is correct with respect to sample data;
# that is, it can parse the sample data without discarding
# any fields.

# This script does not touch the regular "src" directory;
# it generates the protos into source code in a temporary
# directory instead. These are included in the
# Google.Events.ValidateSchema project.

# One command-line parameter is required: the location of
# the root of the local google-cloudevents repo.

if [[ -z "$1" ]]
then
  echo "Please specify the location of the google-cloudevents repo"
  exit 1
fi

GOOGLE_CLOUDEVENTS=$(realpath $1)

set -e

# First change to the location of this script, for simplicity.
cd $(dirname $(readlink -f "$0"))

# Generate code: this is a modified subset of generate-code.sh.
# (At some point we may wish to extract out commonality, but
# that can come later when all of this is more stable.)

rm -rf tmp
mkdir tmp

PROTOBUF_VERSION=3.12.3
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

echo "- Downloading protobuf tools"
cd tmp
curl -sSL \
  https://github.com/protocolbuffers/protobuf/releases/download/v$PROTOBUF_VERSION/protoc-$PROTOBUF_VERSION-$PROTOBUF_PLATFORM.zip \
  --output protobuf.zip
(mkdir protobuf && cd protobuf && unzip -q ../protobuf.zip)
cd ..
chmod +x $PROTOC

mkdir tmp/ValidationSource

echo "- Generating C# from protobuf messages"
$PROTOC \
  --csharp_out=tmp/ValidationSource \
  --csharp_opt=base_namespace=Google.Events.Protobuf \
  --csharp_opt=file_extension=.g.cs \
  -I tmp/protobuf/include \
  -I $GOOGLE_CLOUDEVENTS/third_party/googleapis \
  -I $GOOGLE_CLOUDEVENTS/proto \
  $(find $GOOGLE_CLOUDEVENTS/proto -name data.proto)

echo "- Testing"
dotnet run --project src/Google.Events.ValidateSchema -- $GOOGLE_CLOUDEVENTS/testdata
