// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/events/firebase/v1/events.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Firebase.V1 {

  /// <summary>Holder for reflection information generated from google/events/firebase/v1/events.proto</summary>
  public static partial class EventsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/firebase/v1/events.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvZXZlbnRzL2ZpcmViYXNlL3YxL2V2ZW50cy5wcm90bxIZZ29v",
            "Z2xlLmV2ZW50cy5maXJlYmFzZS52MRoeZ29vZ2xlL2V2ZW50cy9jbG91ZGV2",
            "ZW50LnByb3RvGhxnb29nbGUvcHJvdG9idWYvc3RydWN0LnByb3RvIoUBCg9E",
            "b2N1bWVudENyZWF0ZWQSOgoEZGF0YRgBIAEoCzIsLmdvb2dsZS5ldmVudHMu",
            "ZmlyZWJhc2UudjEuRG9jdW1lbnRFdmVudERhdGE6NoLiCTJnb29nbGUuY2xv",
            "dWQuZmlyZWJhc2UuZGF0YWJhc2UuZG9jdW1lbnQudjEuY3JlYXRlZCKFAQoP",
            "RG9jdW1lbnRVcGRhdGVkEjoKBGRhdGEYASABKAsyLC5nb29nbGUuZXZlbnRz",
            "LmZpcmViYXNlLnYxLkRvY3VtZW50RXZlbnREYXRhOjaC4gkyZ29vZ2xlLmNs",
            "b3VkLmZpcmViYXNlLmRhdGFiYXNlLmRvY3VtZW50LnYxLnVwZGF0ZWQihQEK",
            "D0RvY3VtZW50RGVsZXRlZBI6CgRkYXRhGAEgASgLMiwuZ29vZ2xlLmV2ZW50",
            "cy5maXJlYmFzZS52MS5Eb2N1bWVudEV2ZW50RGF0YTo2guIJMmdvb2dsZS5j",
            "bG91ZC5maXJlYmFzZS5kYXRhYmFzZS5kb2N1bWVudC52MS5kZWxldGVkIoUB",
            "Cg9Eb2N1bWVudFdyaXR0ZW4SOgoEZGF0YRgBIAEoCzIsLmdvb2dsZS5ldmVu",
            "dHMuZmlyZWJhc2UudjEuRG9jdW1lbnRFdmVudERhdGE6NoLiCTJnb29nbGUu",
            "Y2xvdWQuZmlyZWJhc2UuZGF0YWJhc2UuZG9jdW1lbnQudjEud3JpdHRlbiLi",
            "AQoRRG9jdW1lbnRFdmVudERhdGESJAoEZGF0YRgBIAEoCzIWLmdvb2dsZS5w",
            "cm90b2J1Zi5WYWx1ZRIlCgVkZWx0YRgCIAEoCzIWLmdvb2dsZS5wcm90b2J1",
            "Zi5WYWx1ZRJOCgl3aWxkY2FyZHMYAyADKAsyOy5nb29nbGUuZXZlbnRzLmZp",
            "cmViYXNlLnYxLkRvY3VtZW50RXZlbnREYXRhLldpbGRjYXJkc0VudHJ5GjAK",
            "DldpbGRjYXJkc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToC",
            "OAFCJaoCIkdvb2dsZS5FdmVudHMuUHJvdG9idWYuRmlyZWJhc2UuVjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Events.Protobuf.CloudeventReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.V1.DocumentCreated), global::Google.Events.Protobuf.Firebase.V1.DocumentCreated.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.V1.DocumentUpdated), global::Google.Events.Protobuf.Firebase.V1.DocumentUpdated.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.V1.DocumentDeleted), global::Google.Events.Protobuf.Firebase.V1.DocumentDeleted.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.V1.DocumentWritten), global::Google.Events.Protobuf.Firebase.V1.DocumentWritten.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.V1.DocumentEventData), global::Google.Events.Protobuf.Firebase.V1.DocumentEventData.Parser, new[]{ "Data", "Delta", "Wildcards" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The CloudEvent raised when a document is created in the Firebase
  /// Real Time Database.
  /// </summary>
  public sealed partial class DocumentCreated : pb::IMessage<DocumentCreated> {
    private static readonly pb::MessageParser<DocumentCreated> _parser = new pb::MessageParser<DocumentCreated>(() => new DocumentCreated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DocumentCreated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.V1.EventsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentCreated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentCreated(DocumentCreated other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentCreated Clone() {
      return new DocumentCreated(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Events.Protobuf.Firebase.V1.DocumentEventData data_;
    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Firebase.V1.DocumentEventData Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DocumentCreated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DocumentCreated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DocumentCreated other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The CloudEvent raised when a document is created in the Firebase
  /// Real Time Database.
  /// </summary>
  public sealed partial class DocumentUpdated : pb::IMessage<DocumentUpdated> {
    private static readonly pb::MessageParser<DocumentUpdated> _parser = new pb::MessageParser<DocumentUpdated>(() => new DocumentUpdated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DocumentUpdated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.V1.EventsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentUpdated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentUpdated(DocumentUpdated other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentUpdated Clone() {
      return new DocumentUpdated(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Events.Protobuf.Firebase.V1.DocumentEventData data_;
    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Firebase.V1.DocumentEventData Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DocumentUpdated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DocumentUpdated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DocumentUpdated other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The CloudEvent raised when a document is created in the Firebase
  /// Real Time Database.
  /// </summary>
  public sealed partial class DocumentDeleted : pb::IMessage<DocumentDeleted> {
    private static readonly pb::MessageParser<DocumentDeleted> _parser = new pb::MessageParser<DocumentDeleted>(() => new DocumentDeleted());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DocumentDeleted> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.V1.EventsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentDeleted() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentDeleted(DocumentDeleted other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentDeleted Clone() {
      return new DocumentDeleted(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Events.Protobuf.Firebase.V1.DocumentEventData data_;
    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Firebase.V1.DocumentEventData Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DocumentDeleted);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DocumentDeleted other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DocumentDeleted other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The CloudEvent raised when a document is written (created, updated
  /// or deleted) in the Firebase Real Time Database.
  /// </summary>
  public sealed partial class DocumentWritten : pb::IMessage<DocumentWritten> {
    private static readonly pb::MessageParser<DocumentWritten> _parser = new pb::MessageParser<DocumentWritten>(() => new DocumentWritten());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DocumentWritten> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.V1.EventsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentWritten() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentWritten(DocumentWritten other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentWritten Clone() {
      return new DocumentWritten(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Events.Protobuf.Firebase.V1.DocumentEventData data_;
    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Firebase.V1.DocumentEventData Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DocumentWritten);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DocumentWritten other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DocumentWritten other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Events.Protobuf.Firebase.V1.DocumentEventData();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The data within all Firebase Real Time Database document events.
  /// </summary>
  public sealed partial class DocumentEventData : pb::IMessage<DocumentEventData> {
    private static readonly pb::MessageParser<DocumentEventData> _parser = new pb::MessageParser<DocumentEventData>(() => new DocumentEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DocumentEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.V1.EventsReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentEventData(DocumentEventData other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      delta_ = other.delta_ != null ? other.delta_.Clone() : null;
      wildcards_ = other.wildcards_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DocumentEventData Clone() {
      return new DocumentEventData(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Value data_;
    /// <summary>
    /// The original data for the document.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Value Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    /// <summary>Field number for the "delta" field.</summary>
    public const int DeltaFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Value delta_;
    /// <summary>
    /// The change in the document data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Value Delta {
      get { return delta_; }
      set {
        delta_ = value;
      }
    }

    /// <summary>Field number for the "wildcards" field.</summary>
    public const int WildcardsFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_wildcards_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 26);
    private readonly pbc::MapField<string, string> wildcards_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The matches from wildcards specified in the event subscription, to the
    /// values of those wildcards in the document name. For example,
    /// a subscription to
    /// `/projects/my_project/databases/(default)/documents/users/{username}`
    /// matching a document with name
    /// `/projects/my_project/databases/(default)/documents/users/marie`
    /// would result in a mapping of `'username': 'marie'`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Wildcards {
      get { return wildcards_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DocumentEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DocumentEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      if (!object.Equals(Delta, other.Delta)) return false;
      if (!Wildcards.Equals(other.Wildcards)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (delta_ != null) hash ^= Delta.GetHashCode();
      hash ^= Wildcards.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (delta_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Delta);
      }
      wildcards_.WriteTo(output, _map_wildcards_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (delta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Delta);
      }
      size += wildcards_.CalculateSize(_map_wildcards_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DocumentEventData other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Data.MergeFrom(other.Data);
      }
      if (other.delta_ != null) {
        if (delta_ == null) {
          Delta = new global::Google.Protobuf.WellKnownTypes.Value();
        }
        Delta.MergeFrom(other.Delta);
      }
      wildcards_.Add(other.wildcards_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (data_ == null) {
              Data = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Data);
            break;
          }
          case 18: {
            if (delta_ == null) {
              Delta = new global::Google.Protobuf.WellKnownTypes.Value();
            }
            input.ReadMessage(Delta);
            break;
          }
          case 26: {
            wildcards_.AddEntriesFrom(input, _map_wildcards_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
