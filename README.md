# Google CloudEvents for  .NET

[![Build Status](https://github.com/googleapis/google-cloudevents-dotnet/actions/workflows/build.yml/badge.svg)](https://github.com/googleapis/google-cloudevents-dotnet/actions/workflows/build.yml)

[![Google.Events.Protobuf](https://img.shields.io/nuget/vpre/Google.Events.Protobuf?label=Google.Events.Protobuf)](https://nuget.org/packages/Google.Events.Protobuf)

## Overview

This repository contains .NET libraries for CloudEvents issued by
Google. The `Google.Events.Protobuf` contains the Google event data
types, using Protocol Buffers as the serialization framework. Each
type is decorated with `CloudEventFormatterAttribute` to indicate an
appropriate `CloudEventFormatter` to use. This allows for seamless
integration in frameworks such as the Functions Framework, without
those frameworks depending on any libraries in this repository
directly.

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
