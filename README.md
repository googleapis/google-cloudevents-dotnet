# Google CloudEvents for  .NET

[![Build Status](https://travis-ci.org/googleapis/google-cloudevents-dotnet.svg?branch=master)](https://travis-ci.org/googleapis/google-cloudevents-dotnet)

## Overview

This repository contains .NET libraries for CloudEvents issued by
Google. The following packages are provided:

- [Google.Events](https://www.nuget.org/packages/Google.Events)
- [Google.Events.Protobuf](https://www.nuget.org/packages/Google.Events.Protobuf)
- [Google.Events.SystemTextJson](https://www.nuget.org/packages/Google.SystemTextJson)

The `Google.Events` package is very small and has no dependencies.
Its purpose is to expose attributes such as
[CloudEventDataConverterAttribute](src/Google.Events/CloudEventDataConverterAttribute.cs),
as well as the
[CloudEventConverters](https://github.com/googleapis/google-cloudevents-dotnet/blob/master/src/Google.Events/CloudEventConverters.cs)
class that uses those attributes.

The remaining packages each contain the Google event data types, but
each package supports a different serialization framework. The
intention is for frameworks such as the [.NET Functions
Framework](https://github.com/GoogleCloudPlatform/functions-framework-dotnet)
to depend only on `Google.Events`, but application code can depend on
whichever package fits in best with their other dependencies. (If
your application already depends on System.Text.Json, you may want
to avoid a dependency on Google.Protobuf, or vice versa.)

This does mean that there are multiple representations of each event
type, which has potential downsides. See [issue
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

See [BUILDING.md](BUILDING) for more information about developing
the code within this repository.
