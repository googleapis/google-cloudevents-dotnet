// Copyright 2023, Google LLC
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
//     source: google/events/firebase/remoteconfig/v1/data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Firebase.RemoteConfig.V1 {

  /// <summary>Holder for reflection information generated from google/events/firebase/remoteconfig/v1/data.proto</summary>
  public static partial class DataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/firebase/remoteconfig/v1/data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvZXZlbnRzL2ZpcmViYXNlL3JlbW90ZWNvbmZpZy92MS9kYXRh",
            "LnByb3RvEiZnb29nbGUuZXZlbnRzLmZpcmViYXNlLnJlbW90ZWNvbmZpZy52",
            "MRofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKLAwoVUmVtb3Rl",
            "Q29uZmlnRXZlbnREYXRhEhYKDnZlcnNpb25fbnVtYmVyGAEgASgDEi8KC3Vw",
            "ZGF0ZV90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBJN",
            "Cgt1cGRhdGVfdXNlchgDIAEoCzI4Lmdvb2dsZS5ldmVudHMuZmlyZWJhc2Uu",
            "cmVtb3RlY29uZmlnLnYxLlJlbW90ZUNvbmZpZ1VzZXISEwoLZGVzY3JpcHRp",
            "b24YBCABKAkSVwoNdXBkYXRlX29yaWdpbhgFIAEoDjJALmdvb2dsZS5ldmVu",
            "dHMuZmlyZWJhc2UucmVtb3RlY29uZmlnLnYxLlJlbW90ZUNvbmZpZ1VwZGF0",
            "ZU9yaWdpbhJTCgt1cGRhdGVfdHlwZRgGIAEoDjI+Lmdvb2dsZS5ldmVudHMu",
            "ZmlyZWJhc2UucmVtb3RlY29uZmlnLnYxLlJlbW90ZUNvbmZpZ1VwZGF0ZVR5",
            "cGUSFwoPcm9sbGJhY2tfc291cmNlGAcgASgDIkIKEFJlbW90ZUNvbmZpZ1Vz",
            "ZXISDAoEbmFtZRgBIAEoCRINCgVlbWFpbBgCIAEoCRIRCglpbWFnZV91cmwY",
            "AyABKAkqdgoYUmVtb3RlQ29uZmlnVXBkYXRlT3JpZ2luEisKJ1JFTU9URV9D",
            "T05GSUdfVVBEQVRFX09SSUdJTl9VTlNQRUNJRklFRBAAEgsKB0NPTlNPTEUQ",
            "ARIMCghSRVNUX0FQSRACEhIKDkFETUlOX1NES19OT0RFEAMqfAoWUmVtb3Rl",
            "Q29uZmlnVXBkYXRlVHlwZRIpCiVSRU1PVEVfQ09ORklHX1VQREFURV9UWVBF",
            "X1VOU1BFQ0lGSUVEEAASFgoSSU5DUkVNRU5UQUxfVVBEQVRFEAESEQoNRk9S",
            "Q0VEX1VQREFURRACEgwKCFJPTExCQUNLEANCaQoqY29tLmdvb2dsZS5ldmVu",
            "dHMuZmlyZWJhc2UucmVtb3RlY29uZmlnLnYxQglEYXRhUHJvdG+qAi9Hb29n",
            "bGUuRXZlbnRzLlByb3RvYnVmLkZpcmViYXNlLlJlbW90ZUNvbmZpZy5WMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin), typeof(global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigEventData), global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigEventData.Parser, new[]{ "VersionNumber", "UpdateTime", "UpdateUser", "Description", "UpdateOrigin", "UpdateType", "RollbackSource" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser), global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser.Parser, new[]{ "Name", "Email", "ImageUrl" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// What type of update was associated with the Remote Config template version.
  /// </summary>
  public enum RemoteConfigUpdateOrigin {
    /// <summary>
    /// Catch-all for unrecognized values.
    /// </summary>
    [pbr::OriginalName("REMOTE_CONFIG_UPDATE_ORIGIN_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The update came from the Firebase UI.
    /// </summary>
    [pbr::OriginalName("CONSOLE")] Console = 1,
    /// <summary>
    /// The update came from the Remote Config REST API.
    /// </summary>
    [pbr::OriginalName("REST_API")] RestApi = 2,
    /// <summary>
    /// The update came from the Firebase Admin Node SDK.
    /// </summary>
    [pbr::OriginalName("ADMIN_SDK_NODE")] AdminSdkNode = 3,
  }

  /// <summary>
  /// Where the Remote Config update action originated.
  /// </summary>
  public enum RemoteConfigUpdateType {
    /// <summary>
    /// Catch-all for unrecognized enum values.
    /// </summary>
    [pbr::OriginalName("REMOTE_CONFIG_UPDATE_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// A regular incremental update.
    /// </summary>
    [pbr::OriginalName("INCREMENTAL_UPDATE")] IncrementalUpdate = 1,
    /// <summary>
    /// A forced update.
    /// The ETag was specified as "*" in an UpdateRemoteConfigRequest
    /// request or the "Force Update" button was pressed on the console.
    /// </summary>
    [pbr::OriginalName("FORCED_UPDATE")] ForcedUpdate = 2,
    /// <summary>
    /// A rollback to a previous Remote Config template.
    /// </summary>
    [pbr::OriginalName("ROLLBACK")] Rollback = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// The data within all Firebase Remote Config events.
  /// </summary>
  public sealed partial class RemoteConfigEventData : pb::IMessage<RemoteConfigEventData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RemoteConfigEventData> _parser = new pb::MessageParser<RemoteConfigEventData>(() => new RemoteConfigEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RemoteConfigEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigEventData(RemoteConfigEventData other) : this() {
      versionNumber_ = other.versionNumber_;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      updateUser_ = other.updateUser_ != null ? other.updateUser_.Clone() : null;
      description_ = other.description_;
      updateOrigin_ = other.updateOrigin_;
      updateType_ = other.updateType_;
      rollbackSource_ = other.rollbackSource_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigEventData Clone() {
      return new RemoteConfigEventData(this);
    }

    /// <summary>Field number for the "version_number" field.</summary>
    public const int VersionNumberFieldNumber = 1;
    private long versionNumber_;
    /// <summary>
    /// The version number of the version's corresponding Remote Config template.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long VersionNumber {
      get { return versionNumber_; }
      set {
        versionNumber_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// When the Remote Config template was written to the Remote Config server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "update_user" field.</summary>
    public const int UpdateUserFieldNumber = 3;
    private global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser updateUser_;
    /// <summary>
    ///  Aggregation of all metadata fields about the account that performed the
    ///  update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser UpdateUser {
      get { return updateUser_; }
      set {
        updateUser_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private string description_ = "";
    /// <summary>
    /// The user-provided description of the corresponding Remote Config template.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_origin" field.</summary>
    public const int UpdateOriginFieldNumber = 5;
    private global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin updateOrigin_ = global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified;
    /// <summary>
    /// Where the update action originated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin UpdateOrigin {
      get { return updateOrigin_; }
      set {
        updateOrigin_ = value;
      }
    }

    /// <summary>Field number for the "update_type" field.</summary>
    public const int UpdateTypeFieldNumber = 6;
    private global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType updateType_ = global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified;
    /// <summary>
    /// What type of update was made.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType UpdateType {
      get { return updateType_; }
      set {
        updateType_ = value;
      }
    }

    /// <summary>Field number for the "rollback_source" field.</summary>
    public const int RollbackSourceFieldNumber = 7;
    private long rollbackSource_;
    /// <summary>
    /// Only present if this version is the result of a rollback, and will be the
    /// version number of the Remote Config template that was rolled-back to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RollbackSource {
      get { return rollbackSource_; }
      set {
        rollbackSource_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RemoteConfigEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RemoteConfigEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VersionNumber != other.VersionNumber) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(UpdateUser, other.UpdateUser)) return false;
      if (Description != other.Description) return false;
      if (UpdateOrigin != other.UpdateOrigin) return false;
      if (UpdateType != other.UpdateType) return false;
      if (RollbackSource != other.RollbackSource) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (VersionNumber != 0L) hash ^= VersionNumber.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (updateUser_ != null) hash ^= UpdateUser.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (UpdateOrigin != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified) hash ^= UpdateOrigin.GetHashCode();
      if (UpdateType != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified) hash ^= UpdateType.GetHashCode();
      if (RollbackSource != 0L) hash ^= RollbackSource.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (VersionNumber != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(VersionNumber);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateTime);
      }
      if (updateUser_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateUser);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (UpdateOrigin != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) UpdateOrigin);
      }
      if (UpdateType != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) UpdateType);
      }
      if (RollbackSource != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(RollbackSource);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (VersionNumber != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(VersionNumber);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpdateTime);
      }
      if (updateUser_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateUser);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (UpdateOrigin != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) UpdateOrigin);
      }
      if (UpdateType != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) UpdateType);
      }
      if (RollbackSource != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(RollbackSource);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (VersionNumber != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VersionNumber);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (updateUser_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateUser);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (UpdateOrigin != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UpdateOrigin);
      }
      if (UpdateType != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UpdateType);
      }
      if (RollbackSource != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RollbackSource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RemoteConfigEventData other) {
      if (other == null) {
        return;
      }
      if (other.VersionNumber != 0L) {
        VersionNumber = other.VersionNumber;
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.updateUser_ != null) {
        if (updateUser_ == null) {
          UpdateUser = new global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser();
        }
        UpdateUser.MergeFrom(other.UpdateUser);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.UpdateOrigin != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin.Unspecified) {
        UpdateOrigin = other.UpdateOrigin;
      }
      if (other.UpdateType != global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType.Unspecified) {
        UpdateType = other.UpdateType;
      }
      if (other.RollbackSource != 0L) {
        RollbackSource = other.RollbackSource;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 8: {
            VersionNumber = input.ReadInt64();
            break;
          }
          case 18: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 26: {
            if (updateUser_ == null) {
              UpdateUser = new global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser();
            }
            input.ReadMessage(UpdateUser);
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            UpdateOrigin = (global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin) input.ReadEnum();
            break;
          }
          case 48: {
            UpdateType = (global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType) input.ReadEnum();
            break;
          }
          case 56: {
            RollbackSource = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            VersionNumber = input.ReadInt64();
            break;
          }
          case 18: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 26: {
            if (updateUser_ == null) {
              UpdateUser = new global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUser();
            }
            input.ReadMessage(UpdateUser);
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            UpdateOrigin = (global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateOrigin) input.ReadEnum();
            break;
          }
          case 48: {
            UpdateType = (global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.RemoteConfigUpdateType) input.ReadEnum();
            break;
          }
          case 56: {
            RollbackSource = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// All the fields associated with the person/service account
  /// that wrote a Remote Config template.
  /// </summary>
  public sealed partial class RemoteConfigUser : pb::IMessage<RemoteConfigUser>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RemoteConfigUser> _parser = new pb::MessageParser<RemoteConfigUser>(() => new RemoteConfigUser());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RemoteConfigUser> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.RemoteConfig.V1.DataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigUser() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigUser(RemoteConfigUser other) : this() {
      name_ = other.name_;
      email_ = other.email_;
      imageUrl_ = other.imageUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RemoteConfigUser Clone() {
      return new RemoteConfigUser(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Display name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    /// <summary>
    /// Email address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_url" field.</summary>
    public const int ImageUrlFieldNumber = 3;
    private string imageUrl_ = "";
    /// <summary>
    /// Image URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ImageUrl {
      get { return imageUrl_; }
      set {
        imageUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RemoteConfigUser);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RemoteConfigUser other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Email != other.Email) return false;
      if (ImageUrl != other.ImageUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (ImageUrl.Length != 0) hash ^= ImageUrl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (ImageUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (ImageUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (ImageUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RemoteConfigUser other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.ImageUrl.Length != 0) {
        ImageUrl = other.ImageUrl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            ImageUrl = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            ImageUrl = input.ReadString();
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
