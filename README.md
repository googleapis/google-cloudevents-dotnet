# Google CloudEvents for  .NET

[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2Fgoogleapis%2Fgoogle-cloudevents-dotnet%2Fbadge&style=flat)](https://actions-badge.atrox.dev/googleapis/google-cloudevents-dotnet/goto)

## Overview

This repository contains .NET libraries for CloudEvents issued by
Google. The following packages are provided:

- [Google.Events](https://www.nuget.org/packages/Google.Events)
- [Google.Events.Protobuf](https://www.nuget.org/packages/Google.Events.Protobuf)

The `Google.Events` package is very small and has no dependencies.
Its purpose is to expose attributes such as
[CloudEventDataConverterAttribute](src/Google.Events/CloudEventDataConverterAttribute.cs),
as well as the
[CloudEventConverters](https://github.com/googleapis/google-cloudevents-dotnet/blob/master/src/Google.Events/CloudEventConverters.cs)
class that uses those attributes.

The `Google.Events.Protobuf` contains the Google event data types,
using Protocol Buffers as the serialization framework.

The design allows for other serialization frameworks (e.g.
System.Text.Json or Json.NET) to be supported in the future, each in
a separate package. Frameworks such as the [.NET Functions
Framework](https://github.com/GoogleCloudPlatform/functions-framework-dotnet)
can depend only on `Google.Events`, but application code can depend
on whichever package fits in best with their other dependencies. (If
your application already depends on System.Text.Json, you may want
to avoid a dependency on Google.Protobuf, or vice versa.)

This does mean that there could be multiple representations of each
event type, which has potential downsides. See [issue
12](https://github.com/googleapis/google-cloudevents-dotnet/issues/12)
for further discussion.

## Usage

From the .NET Functions Framework, these packages are automatically
used for CloudEvent functions implementing
`ICloudEventFunction<TData>`, where `TData` is one of the event data
classes.

If you wish to use these classes in a different context, code might
typically look something like this:

```csharp
CloudEvent cloudEvent = ...; // However you obtain a CloudEvent

// The event data type from any of the serialization-specific packages.
StorageObjectData data = CloudEventConverters.ConvertCloudEventData<StorageData>(cloudEvent);
```

## Development

See [BUILDING](BUILDING.md) for more information about developing
the code within this repository.
