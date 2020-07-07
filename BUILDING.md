# Building

Prerequisites:

- `.NET Core SDK 3.1`

To build the packages, run:

```sh
./build.sh
```

This will build the C# code and run tests.

## Regenerating event data classes

When the [google-cloudevents repo](https://github.com/googleapis/google-cloudevents) is updated,
the C# classes need to be regenerated:

```sh
./generate-code.sh
```

This will regenerate the proto-based classes in
[src/Google.Events.Protobuf/](src/Google.Events.Protobuf),
as well as generating converter attributes and CloudEvent type
constants.

---

If event data types or properties have been added,
the tests for other serialization frameworks will fail.
The tests should currently be fixed by manually adding the corresponding types and properties.
