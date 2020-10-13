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

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/events/firebase/database/v1/data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Firebase.Database.V1 {

  /// <summary>Holder for reflection information generated from google/events/firebase/database/v1/data.proto</summary>
  public static partial class DataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/firebase/database/v1/data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvZXZlbnRzL2ZpcmViYXNlL2RhdGFiYXNlL3YxL2RhdGEucHJv",
            "dG8SImdvb2dsZS5ldmVudHMuZmlyZWJhc2UuZGF0YWJhc2UudjEaHGdvb2ds",
            "ZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8iYQoSUmVmZXJlbmNlRXZlbnREYXRh",
            "EiQKBGRhdGEYASABKAsyFi5nb29nbGUucHJvdG9idWYuVmFsdWUSJQoFZGVs",
            "dGEYAiABKAsyFi5nb29nbGUucHJvdG9idWYuVmFsdWVCLqoCK0dvb2dsZS5F",
            "dmVudHMuUHJvdG9idWYuRmlyZWJhc2UuRGF0YWJhc2UuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.Database.V1.ReferenceEventData), global::Google.Events.Protobuf.Firebase.Database.V1.ReferenceEventData.Parser, new[]{ "Data", "Delta" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The data within all Firebase Real Time Database reference events.
  /// </summary>
  public sealed partial class ReferenceEventData : pb::IMessage<ReferenceEventData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReferenceEventData> _parser = new pb::MessageParser<ReferenceEventData>(() => new ReferenceEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReferenceEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.Database.V1.DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReferenceEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReferenceEventData(ReferenceEventData other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      delta_ = other.delta_ != null ? other.delta_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReferenceEventData Clone() {
      return new ReferenceEventData(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Value data_;
    /// <summary>
    /// The original data for the reference.
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
    /// The change in the reference data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Value Delta {
      get { return delta_; }
      set {
        delta_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReferenceEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReferenceEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      if (!object.Equals(Delta, other.Delta)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
      if (delta_ != null) hash ^= Delta.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (delta_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Delta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (delta_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Delta);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (delta_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Delta);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReferenceEventData other) {
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
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
