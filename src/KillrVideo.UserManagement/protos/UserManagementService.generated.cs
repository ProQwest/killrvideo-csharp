// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: user-management/user_management_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KillrVideo.UserManagement {

  /// <summary>Holder for reflection information generated from user-management/user_management_service.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UserManagementServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for user-management/user_management_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserManagementServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci11c2VyLW1hbmFnZW1lbnQvdXNlcl9tYW5hZ2VtZW50X3NlcnZpY2UucHJv",
            "dG8SGmtpbGxydmlkZW8udXNlcl9tYW5hZ2VtZW50Ghljb21tb24vY29tbW9u",
            "X3R5cGVzLnByb3RvIoUBChFDcmVhdGVVc2VyUmVxdWVzdBIoCgd1c2VyX2lk",
            "GAEgASgLMhcua2lsbHJ2aWRlby5jb21tb24uVXVpZBISCgpmaXJzdF9uYW1l",
            "GAIgASgJEhEKCWxhc3RfbmFtZRgDIAEoCRINCgVlbWFpbBgEIAEoCRIQCghw",
            "YXNzd29yZBgFIAEoCSIUChJDcmVhdGVVc2VyUmVzcG9uc2UiOwoYVmVyaWZ5",
            "Q3JlZGVudGlhbHNSZXF1ZXN0Eg0KBWVtYWlsGAEgASgJEhAKCHBhc3N3b3Jk",
            "GAIgASgJIkUKGVZlcmlmeUNyZWRlbnRpYWxzUmVzcG9uc2USKAoHdXNlcl9p",
            "ZBgBIAEoCzIXLmtpbGxydmlkZW8uY29tbW9uLlV1aWQiQgoVR2V0VXNlclBy",
            "b2ZpbGVSZXF1ZXN0EikKCHVzZXJfaWRzGAEgAygLMhcua2lsbHJ2aWRlby5j",
            "b21tb24uVXVpZCJTChZHZXRVc2VyUHJvZmlsZVJlc3BvbnNlEjkKCHByb2Zp",
            "bGVzGAEgAygLMicua2lsbHJ2aWRlby51c2VyX21hbmFnZW1lbnQuVXNlclBy",
            "b2ZpbGUibQoLVXNlclByb2ZpbGUSKAoHdXNlcl9pZBgBIAEoCzIXLmtpbGxy",
            "dmlkZW8uY29tbW9uLlV1aWQSEgoKZmlyc3RfbmFtZRgCIAEoCRIRCglsYXN0",
            "X25hbWUYAyABKAkSDQoFZW1haWwYBCABKAkygAMKFVVzZXJNYW5hZ2VtZW50",
            "U2VydmljZRJrCgpDcmVhdGVVc2VyEi0ua2lsbHJ2aWRlby51c2VyX21hbmFn",
            "ZW1lbnQuQ3JlYXRlVXNlclJlcXVlc3QaLi5raWxscnZpZGVvLnVzZXJfbWFu",
            "YWdlbWVudC5DcmVhdGVVc2VyUmVzcG9uc2USgAEKEVZlcmlmeUNyZWRlbnRp",
            "YWxzEjQua2lsbHJ2aWRlby51c2VyX21hbmFnZW1lbnQuVmVyaWZ5Q3JlZGVu",
            "dGlhbHNSZXF1ZXN0GjUua2lsbHJ2aWRlby51c2VyX21hbmFnZW1lbnQuVmVy",
            "aWZ5Q3JlZGVudGlhbHNSZXNwb25zZRJ3Cg5HZXRVc2VyUHJvZmlsZRIxLmtp",
            "bGxydmlkZW8udXNlcl9tYW5hZ2VtZW50LkdldFVzZXJQcm9maWxlUmVxdWVz",
            "dBoyLmtpbGxydmlkZW8udXNlcl9tYW5hZ2VtZW50LkdldFVzZXJQcm9maWxl",
            "UmVzcG9uc2VCHKoCGUtpbGxyVmlkZW8uVXNlck1hbmFnZW1lbnRiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::KillrVideo.Common.CommonTypesReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.CreateUserRequest), global::KillrVideo.UserManagement.CreateUserRequest.Parser, new[]{ "UserId", "FirstName", "LastName", "Email", "Password" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.CreateUserResponse), global::KillrVideo.UserManagement.CreateUserResponse.Parser, null, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.VerifyCredentialsRequest), global::KillrVideo.UserManagement.VerifyCredentialsRequest.Parser, new[]{ "Email", "Password" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.VerifyCredentialsResponse), global::KillrVideo.UserManagement.VerifyCredentialsResponse.Parser, new[]{ "UserId" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.GetUserProfileRequest), global::KillrVideo.UserManagement.GetUserProfileRequest.Parser, new[]{ "UserIds" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.GetUserProfileResponse), global::KillrVideo.UserManagement.GetUserProfileResponse.Parser, new[]{ "Profiles" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.UserManagement.UserProfile), global::KillrVideo.UserManagement.UserProfile.Parser, new[]{ "UserId", "FirstName", "LastName", "Email" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Request to create a new user
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CreateUserRequest : pb::IMessage<CreateUserRequest> {
    private static readonly pb::MessageParser<CreateUserRequest> _parser = new pb::MessageParser<CreateUserRequest>(() => new CreateUserRequest());
    public static pb::MessageParser<CreateUserRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CreateUserRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CreateUserRequest(CreateUserRequest other) : this() {
      UserId = other.userId_ != null ? other.UserId.Clone() : null;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      email_ = other.email_;
      password_ = other.password_;
    }

    public CreateUserRequest Clone() {
      return new CreateUserRequest(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private global::KillrVideo.Common.Uuid userId_;
    public global::KillrVideo.Common.Uuid UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 2;
    private string firstName_ = "";
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 4;
    private string email_ = "";
    public string Email {
      get { return email_; }
      set {
        email_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 5;
    private string password_ = "";
    public string Password {
      get { return password_; }
      set {
        password_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CreateUserRequest);
    }

    public bool Equals(CreateUserRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserId, other.UserId)) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Email != other.Email) return false;
      if (Password != other.Password) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (userId_ != null) hash ^= UserId.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (userId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserId);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Email);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Password);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserId);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(CreateUserRequest other) {
      if (other == null) {
        return;
      }
      if (other.userId_ != null) {
        if (userId_ == null) {
          userId_ = new global::KillrVideo.Common.Uuid();
        }
        UserId.MergeFrom(other.UserId);
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (userId_ == null) {
              userId_ = new global::KillrVideo.Common.Uuid();
            }
            input.ReadMessage(userId_);
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Email = input.ReadString();
            break;
          }
          case 42: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response when creating a new user
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CreateUserResponse : pb::IMessage<CreateUserResponse> {
    private static readonly pb::MessageParser<CreateUserResponse> _parser = new pb::MessageParser<CreateUserResponse>(() => new CreateUserResponse());
    public static pb::MessageParser<CreateUserResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CreateUserResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CreateUserResponse(CreateUserResponse other) : this() {
    }

    public CreateUserResponse Clone() {
      return new CreateUserResponse(this);
    }

    public override bool Equals(object other) {
      return Equals(other as CreateUserResponse);
    }

    public bool Equals(CreateUserResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(CreateUserResponse other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  ///  Request to verify a user's credentials (i.e. for logging them in)
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VerifyCredentialsRequest : pb::IMessage<VerifyCredentialsRequest> {
    private static readonly pb::MessageParser<VerifyCredentialsRequest> _parser = new pb::MessageParser<VerifyCredentialsRequest>(() => new VerifyCredentialsRequest());
    public static pb::MessageParser<VerifyCredentialsRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public VerifyCredentialsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public VerifyCredentialsRequest(VerifyCredentialsRequest other) : this() {
      email_ = other.email_;
      password_ = other.password_;
    }

    public VerifyCredentialsRequest Clone() {
      return new VerifyCredentialsRequest(this);
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 1;
    private string email_ = "";
    public string Email {
      get { return email_; }
      set {
        email_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    public string Password {
      get { return password_; }
      set {
        password_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as VerifyCredentialsRequest);
    }

    public bool Equals(VerifyCredentialsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Email != other.Email) return false;
      if (Password != other.Password) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Email.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Email);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(VerifyCredentialsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Email = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response that indicates the user's id if the credentials were correct
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VerifyCredentialsResponse : pb::IMessage<VerifyCredentialsResponse> {
    private static readonly pb::MessageParser<VerifyCredentialsResponse> _parser = new pb::MessageParser<VerifyCredentialsResponse>(() => new VerifyCredentialsResponse());
    public static pb::MessageParser<VerifyCredentialsResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public VerifyCredentialsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public VerifyCredentialsResponse(VerifyCredentialsResponse other) : this() {
      UserId = other.userId_ != null ? other.UserId.Clone() : null;
    }

    public VerifyCredentialsResponse Clone() {
      return new VerifyCredentialsResponse(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private global::KillrVideo.Common.Uuid userId_;
    public global::KillrVideo.Common.Uuid UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as VerifyCredentialsResponse);
    }

    public bool Equals(VerifyCredentialsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserId, other.UserId)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (userId_ != null) hash ^= UserId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (userId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserId);
      }
      return size;
    }

    public void MergeFrom(VerifyCredentialsResponse other) {
      if (other == null) {
        return;
      }
      if (other.userId_ != null) {
        if (userId_ == null) {
          userId_ = new global::KillrVideo.Common.Uuid();
        }
        UserId.MergeFrom(other.UserId);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (userId_ == null) {
              userId_ = new global::KillrVideo.Common.Uuid();
            }
            input.ReadMessage(userId_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Request to get a user or multiple users profiles
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetUserProfileRequest : pb::IMessage<GetUserProfileRequest> {
    private static readonly pb::MessageParser<GetUserProfileRequest> _parser = new pb::MessageParser<GetUserProfileRequest>(() => new GetUserProfileRequest());
    public static pb::MessageParser<GetUserProfileRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetUserProfileRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetUserProfileRequest(GetUserProfileRequest other) : this() {
      userIds_ = other.userIds_.Clone();
    }

    public GetUserProfileRequest Clone() {
      return new GetUserProfileRequest(this);
    }

    /// <summary>Field number for the "user_ids" field.</summary>
    public const int UserIdsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::KillrVideo.Common.Uuid> _repeated_userIds_codec
        = pb::FieldCodec.ForMessage(10, global::KillrVideo.Common.Uuid.Parser);
    private readonly pbc::RepeatedField<global::KillrVideo.Common.Uuid> userIds_ = new pbc::RepeatedField<global::KillrVideo.Common.Uuid>();
    public pbc::RepeatedField<global::KillrVideo.Common.Uuid> UserIds {
      get { return userIds_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GetUserProfileRequest);
    }

    public bool Equals(GetUserProfileRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!userIds_.Equals(other.userIds_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= userIds_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      userIds_.WriteTo(output, _repeated_userIds_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += userIds_.CalculateSize(_repeated_userIds_codec);
      return size;
    }

    public void MergeFrom(GetUserProfileRequest other) {
      if (other == null) {
        return;
      }
      userIds_.Add(other.userIds_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            userIds_.AddEntriesFrom(input, _repeated_userIds_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response with user profiles
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetUserProfileResponse : pb::IMessage<GetUserProfileResponse> {
    private static readonly pb::MessageParser<GetUserProfileResponse> _parser = new pb::MessageParser<GetUserProfileResponse>(() => new GetUserProfileResponse());
    public static pb::MessageParser<GetUserProfileResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetUserProfileResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetUserProfileResponse(GetUserProfileResponse other) : this() {
      profiles_ = other.profiles_.Clone();
    }

    public GetUserProfileResponse Clone() {
      return new GetUserProfileResponse(this);
    }

    /// <summary>Field number for the "profiles" field.</summary>
    public const int ProfilesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::KillrVideo.UserManagement.UserProfile> _repeated_profiles_codec
        = pb::FieldCodec.ForMessage(10, global::KillrVideo.UserManagement.UserProfile.Parser);
    private readonly pbc::RepeatedField<global::KillrVideo.UserManagement.UserProfile> profiles_ = new pbc::RepeatedField<global::KillrVideo.UserManagement.UserProfile>();
    public pbc::RepeatedField<global::KillrVideo.UserManagement.UserProfile> Profiles {
      get { return profiles_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GetUserProfileResponse);
    }

    public bool Equals(GetUserProfileResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!profiles_.Equals(other.profiles_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= profiles_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      profiles_.WriteTo(output, _repeated_profiles_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += profiles_.CalculateSize(_repeated_profiles_codec);
      return size;
    }

    public void MergeFrom(GetUserProfileResponse other) {
      if (other == null) {
        return;
      }
      profiles_.Add(other.profiles_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            profiles_.AddEntriesFrom(input, _repeated_profiles_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  A user's profile information
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class UserProfile : pb::IMessage<UserProfile> {
    private static readonly pb::MessageParser<UserProfile> _parser = new pb::MessageParser<UserProfile>(() => new UserProfile());
    public static pb::MessageParser<UserProfile> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.UserManagement.UserManagementServiceReflection.Descriptor.MessageTypes[6]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public UserProfile() {
      OnConstruction();
    }

    partial void OnConstruction();

    public UserProfile(UserProfile other) : this() {
      UserId = other.userId_ != null ? other.UserId.Clone() : null;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      email_ = other.email_;
    }

    public UserProfile Clone() {
      return new UserProfile(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private global::KillrVideo.Common.Uuid userId_;
    public global::KillrVideo.Common.Uuid UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 2;
    private string firstName_ = "";
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 4;
    private string email_ = "";
    public string Email {
      get { return email_; }
      set {
        email_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as UserProfile);
    }

    public bool Equals(UserProfile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserId, other.UserId)) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Email != other.Email) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (userId_ != null) hash ^= UserId.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (userId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserId);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Email);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserId);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      return size;
    }

    public void MergeFrom(UserProfile other) {
      if (other == null) {
        return;
      }
      if (other.userId_ != null) {
        if (userId_ == null) {
          userId_ = new global::KillrVideo.Common.Uuid();
        }
        UserId.MergeFrom(other.UserId);
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (userId_ == null) {
              userId_ = new global::KillrVideo.Common.Uuid();
            }
            input.ReadMessage(userId_);
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Email = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
