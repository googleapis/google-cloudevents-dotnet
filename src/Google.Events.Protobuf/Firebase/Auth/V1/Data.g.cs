// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/events/firebase/auth/v1/data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Firebase.Auth.V1 {

  /// <summary>Holder for reflection information generated from google/events/firebase/auth/v1/data.proto</summary>
  public static partial class DataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/firebase/auth/v1/data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvZXZlbnRzL2ZpcmViYXNlL2F1dGgvdjEvZGF0YS5wcm90bxIe",
            "Z29vZ2xlLmV2ZW50cy5maXJlYmFzZS5hdXRoLnYxGhxnb29nbGUvcHJvdG9i",
            "dWYvc3RydWN0LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnBy",
            "b3RvIsUCCg1BdXRoRXZlbnREYXRhEgsKA3VpZBgBIAEoCRINCgVlbWFpbBgC",
            "IAEoCRIWCg5lbWFpbF92ZXJpZmllZBgDIAEoCBIUCgxkaXNwbGF5X25hbWUY",
            "BCABKAkSEQoJcGhvdG9fVVJMGAUgASgJEhAKCGRpc2FibGVkGAYgASgIEj4K",
            "CG1ldGFkYXRhGAcgASgLMiwuZ29vZ2xlLmV2ZW50cy5maXJlYmFzZS5hdXRo",
            "LnYxLlVzZXJNZXRhZGF0YRI/Cg1wcm92aWRlcl9kYXRhGAggAygLMiguZ29v",
            "Z2xlLmV2ZW50cy5maXJlYmFzZS5hdXRoLnYxLlVzZXJJbmZvEhQKDHBob25l",
            "X251bWJlchgJIAEoCRIuCg1jdXN0b21fY2xhaW1zGAogASgLMhcuZ29vZ2xl",
            "LnByb3RvYnVmLlN0cnVjdCJ1CgxVc2VyTWV0YWRhdGESLgoKY3JlYXRlZF9h",
            "dBgBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASNQoRbGFzdF9z",
            "aWduZWRfaW5fYXQYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "ImQKCFVzZXJJbmZvEgsKA3VpZBgBIAEoCRINCgVlbWFpbBgCIAEoCRIUCgxk",
            "aXNwbGF5X25hbWUYAyABKAkSEQoJcGhvdG9fVVJMGAQgASgJEhMKC3Byb3Zp",
            "ZGVyX2lkGAUgASgJQiqqAidHb29nbGUuRXZlbnRzLlByb3RvYnVmLkZpcmVi",
            "YXNlLkF1dGguVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.Auth.V1.AuthEventData), global::Google.Events.Protobuf.Firebase.Auth.V1.AuthEventData.Parser, new[]{ "Uid", "Email", "EmailVerified", "DisplayName", "PhotoURL", "Disabled", "Metadata", "ProviderData", "PhoneNumber", "CustomClaims" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata), global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata.Parser, new[]{ "CreatedAt", "LastSignedInAt" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo), global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo.Parser, new[]{ "Uid", "Email", "DisplayName", "PhotoURL", "ProviderId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The data within all Firebase Auth events
  /// </summary>
  public sealed partial class AuthEventData : pb::IMessage<AuthEventData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthEventData> _parser = new pb::MessageParser<AuthEventData>(() => new AuthEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.Auth.V1.DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthEventData(AuthEventData other) : this() {
      uid_ = other.uid_;
      email_ = other.email_;
      emailVerified_ = other.emailVerified_;
      displayName_ = other.displayName_;
      photoURL_ = other.photoURL_;
      disabled_ = other.disabled_;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      providerData_ = other.providerData_.Clone();
      phoneNumber_ = other.phoneNumber_;
      customClaims_ = other.customClaims_ != null ? other.customClaims_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthEventData Clone() {
      return new AuthEventData(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private string uid_ = "";
    /// <summary>
    /// The user identifier in the Firebase app.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    /// <summary>
    /// The user's primary email, if set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email_verified" field.</summary>
    public const int EmailVerifiedFieldNumber = 3;
    private bool emailVerified_;
    /// <summary>
    /// Whether or not the user's primary email is verified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EmailVerified {
      get { return emailVerified_; }
      set {
        emailVerified_ = value;
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 4;
    private string displayName_ = "";
    /// <summary>
    /// The user's display name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "photo_URL" field.</summary>
    public const int PhotoURLFieldNumber = 5;
    private string photoURL_ = "";
    /// <summary>
    /// The user's photo URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PhotoURL {
      get { return photoURL_; }
      set {
        photoURL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disabled" field.</summary>
    public const int DisabledFieldNumber = 6;
    private bool disabled_;
    /// <summary>
    /// Whether the user is disabled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Disabled {
      get { return disabled_; }
      set {
        disabled_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 7;
    private global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata metadata_;
    /// <summary>
    /// Additional metadata about the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "provider_data" field.</summary>
    public const int ProviderDataFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo> _repeated_providerData_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo> providerData_ = new pbc::RepeatedField<global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo>();
    /// <summary>
    /// User's info at the providers
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Events.Protobuf.Firebase.Auth.V1.UserInfo> ProviderData {
      get { return providerData_; }
    }

    /// <summary>Field number for the "phone_number" field.</summary>
    public const int PhoneNumberFieldNumber = 9;
    private string phoneNumber_ = "";
    /// <summary>
    /// The user's phone number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "custom_claims" field.</summary>
    public const int CustomClaimsFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Struct customClaims_;
    /// <summary>
    /// User's custom claims, typically used to define user roles and propagated
    /// to an authenticated user's ID token.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct CustomClaims {
      get { return customClaims_; }
      set {
        customClaims_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Email != other.Email) return false;
      if (EmailVerified != other.EmailVerified) return false;
      if (DisplayName != other.DisplayName) return false;
      if (PhotoURL != other.PhotoURL) return false;
      if (Disabled != other.Disabled) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if(!providerData_.Equals(other.providerData_)) return false;
      if (PhoneNumber != other.PhoneNumber) return false;
      if (!object.Equals(CustomClaims, other.CustomClaims)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (EmailVerified != false) hash ^= EmailVerified.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (PhotoURL.Length != 0) hash ^= PhotoURL.GetHashCode();
      if (Disabled != false) hash ^= Disabled.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      hash ^= providerData_.GetHashCode();
      if (PhoneNumber.Length != 0) hash ^= PhoneNumber.GetHashCode();
      if (customClaims_ != null) hash ^= CustomClaims.GetHashCode();
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
      if (Uid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uid);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (EmailVerified != false) {
        output.WriteRawTag(24);
        output.WriteBool(EmailVerified);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PhotoURL);
      }
      if (Disabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(Disabled);
      }
      if (metadata_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Metadata);
      }
      providerData_.WriteTo(output, _repeated_providerData_codec);
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PhoneNumber);
      }
      if (customClaims_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CustomClaims);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Uid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uid);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (EmailVerified != false) {
        output.WriteRawTag(24);
        output.WriteBool(EmailVerified);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PhotoURL);
      }
      if (Disabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(Disabled);
      }
      if (metadata_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Metadata);
      }
      providerData_.WriteTo(ref output, _repeated_providerData_codec);
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PhoneNumber);
      }
      if (customClaims_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CustomClaims);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (EmailVerified != false) {
        size += 1 + 1;
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhotoURL);
      }
      if (Disabled != false) {
        size += 1 + 1;
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      size += providerData_.CalculateSize(_repeated_providerData_codec);
      if (PhoneNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber);
      }
      if (customClaims_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomClaims);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthEventData other) {
      if (other == null) {
        return;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.EmailVerified != false) {
        EmailVerified = other.EmailVerified;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.PhotoURL.Length != 0) {
        PhotoURL = other.PhotoURL;
      }
      if (other.Disabled != false) {
        Disabled = other.Disabled;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      providerData_.Add(other.providerData_);
      if (other.PhoneNumber.Length != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      if (other.customClaims_ != null) {
        if (customClaims_ == null) {
          CustomClaims = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        CustomClaims.MergeFrom(other.CustomClaims);
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
            Uid = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 24: {
            EmailVerified = input.ReadBool();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            PhotoURL = input.ReadString();
            break;
          }
          case 48: {
            Disabled = input.ReadBool();
            break;
          }
          case 58: {
            if (metadata_ == null) {
              Metadata = new global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 66: {
            providerData_.AddEntriesFrom(input, _repeated_providerData_codec);
            break;
          }
          case 74: {
            PhoneNumber = input.ReadString();
            break;
          }
          case 82: {
            if (customClaims_ == null) {
              CustomClaims = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(CustomClaims);
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
            Uid = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 24: {
            EmailVerified = input.ReadBool();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            PhotoURL = input.ReadString();
            break;
          }
          case 48: {
            Disabled = input.ReadBool();
            break;
          }
          case 58: {
            if (metadata_ == null) {
              Metadata = new global::Google.Events.Protobuf.Firebase.Auth.V1.UserMetadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 66: {
            providerData_.AddEntriesFrom(ref input, _repeated_providerData_codec);
            break;
          }
          case 74: {
            PhoneNumber = input.ReadString();
            break;
          }
          case 82: {
            if (customClaims_ == null) {
              CustomClaims = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(CustomClaims);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Additional metadata about the user.
  /// </summary>
  public sealed partial class UserMetadata : pb::IMessage<UserMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserMetadata> _parser = new pb::MessageParser<UserMetadata>(() => new UserMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.Auth.V1.DataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserMetadata(UserMetadata other) : this() {
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      lastSignedInAt_ = other.lastSignedInAt_ != null ? other.lastSignedInAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserMetadata Clone() {
      return new UserMetadata(this);
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// The date the user was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "last_signed_in_at" field.</summary>
    public const int LastSignedInAtFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastSignedInAt_;
    /// <summary>
    /// The date the user last signed in.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastSignedInAt {
      get { return lastSignedInAt_; }
      set {
        lastSignedInAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (!object.Equals(LastSignedInAt, other.LastSignedInAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (lastSignedInAt_ != null) hash ^= LastSignedInAt.GetHashCode();
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
      if (createdAt_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreatedAt);
      }
      if (lastSignedInAt_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LastSignedInAt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (createdAt_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreatedAt);
      }
      if (lastSignedInAt_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LastSignedInAt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (lastSignedInAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastSignedInAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserMetadata other) {
      if (other == null) {
        return;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.lastSignedInAt_ != null) {
        if (lastSignedInAt_ == null) {
          LastSignedInAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastSignedInAt.MergeFrom(other.LastSignedInAt);
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
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 18: {
            if (lastSignedInAt_ == null) {
              LastSignedInAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastSignedInAt);
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
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 18: {
            if (lastSignedInAt_ == null) {
              LastSignedInAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastSignedInAt);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// User's info at the identity provider
  /// </summary>
  public sealed partial class UserInfo : pb::IMessage<UserInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserInfo> _parser = new pb::MessageParser<UserInfo>(() => new UserInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Firebase.Auth.V1.DataReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo(UserInfo other) : this() {
      uid_ = other.uid_;
      email_ = other.email_;
      displayName_ = other.displayName_;
      photoURL_ = other.photoURL_;
      providerId_ = other.providerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInfo Clone() {
      return new UserInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private string uid_ = "";
    /// <summary>
    /// The user identifier for the linked provider.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 2;
    private string email_ = "";
    /// <summary>
    /// The email for the linked provider.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private string displayName_ = "";
    /// <summary>
    /// The display name for the linked provider.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "photo_URL" field.</summary>
    public const int PhotoURLFieldNumber = 4;
    private string photoURL_ = "";
    /// <summary>
    /// The photo URL for the linked provider.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PhotoURL {
      get { return photoURL_; }
      set {
        photoURL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_id" field.</summary>
    public const int ProviderIdFieldNumber = 5;
    private string providerId_ = "";
    /// <summary>
    /// The linked provider ID (e.g. "google.com" for the Google provider).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderId {
      get { return providerId_; }
      set {
        providerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Email != other.Email) return false;
      if (DisplayName != other.DisplayName) return false;
      if (PhotoURL != other.PhotoURL) return false;
      if (ProviderId != other.ProviderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (PhotoURL.Length != 0) hash ^= PhotoURL.GetHashCode();
      if (ProviderId.Length != 0) hash ^= ProviderId.GetHashCode();
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
      if (Uid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uid);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PhotoURL);
      }
      if (ProviderId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ProviderId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Uid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uid);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Email);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PhotoURL);
      }
      if (ProviderId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ProviderId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (PhotoURL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhotoURL);
      }
      if (ProviderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.PhotoURL.Length != 0) {
        PhotoURL = other.PhotoURL;
      }
      if (other.ProviderId.Length != 0) {
        ProviderId = other.ProviderId;
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
            Uid = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            PhotoURL = input.ReadString();
            break;
          }
          case 42: {
            ProviderId = input.ReadString();
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
            Uid = input.ReadString();
            break;
          }
          case 18: {
            Email = input.ReadString();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            PhotoURL = input.ReadString();
            break;
          }
          case 42: {
            ProviderId = input.ReadString();
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
