# Building

Build prerequisites: .NET Core SDK 3.1

To build the packages, simply run [`build.sh`](build.sh) from the root
directory. This will build the C# code and run tests.

## Regenerating event data classes

When the [google-cloudevents
repo](https://github.com/googleapis/google-cloudevents) is updated,
the C# classes need to be regenerated. Run
[`generate-protos.sh`](generate-protos.sh) from the root directory to
do this; the proto-based classes in [src/Google.Events.Protobuf](src/Google.Events.Protobuf) will be
regenerated.

If event data types or properties have been added, the tests for
other serialization frameworks will fail; the tests should currently
be fixed by manually adding the corresponding types and properties.

Note: this is currently only supported on Linux and Windows; if you
are developing on another platform, please edit `generate-protos.sh`
appropriately, and create a pull request with the changes. (It's just
a matter of knowing which zip file to download for `protoc`, and
where the `protoc` binary is within it.)
