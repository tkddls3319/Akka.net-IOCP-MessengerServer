// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClusterProtocol.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.ClusterProtocol {

  /// <summary>Holder for reflection information generated from ClusterProtocol.proto</summary>
  public static partial class ClusterProtocolReflection {

    #region Descriptor
    /// <summary>File descriptor for ClusterProtocol.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClusterProtocolReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDbHVzdGVyUHJvdG9jb2wucHJvdG8SD0NsdXN0ZXJQcm90b2NvbBofZ29v",
            "Z2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJDChZTTF9DaGF0V3JpdGVM",
            "b2dDb21tYW5kEikKBENoYXQYASABKAsyGy5DbHVzdGVyUHJvdG9jb2wuQ2hh",
            "dE9iamVjdCIlChNTTF9DaGF0UmVhZExvZ1F1ZXJ5Eg4KBnJvb21JZBgBIAEo",
            "BSJEChZMU19DaGF0UmVhZExvZ1Jlc3BvbnNlEioKBWNoYXRzGAEgAygLMhsu",
            "Q2x1c3RlclByb3RvY29sLkNoYXRPYmplY3QiewoKQ2hhdE9iamVjdBIQCghv",
            "YmplY3RJZBgBIAEoBRIOCgZyb29tSWQYAiABKAUSDAoEY2hhdBgDIAEoCRIo",
            "CgR0aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBITCgth",
            "Y2NvdXRuTmFtZRgFIAEoCSIYChZBU19HZXRBbGxSb29tSW5mb1F1ZXJ5IkkK",
            "GVNBX0dldEFsbFJvb21JbmZvUmVzcG9uc2USLAoJcm9vbUluZm9zGAEgAygL",
            "MhkuQ2x1c3RlclByb3RvY29sLlJvb21JbmZvIkIKCFJvb21JbmZvEg4KBnJv",
            "b21JRBgBIAEoBRIQCghtYXhDb3VudBgCIAEoBRIUCgxjdXJyZW50Q291bnQY",
            "AyABKAVCIqoCH0dvb2dsZS5Qcm90b2J1Zi5DbHVzdGVyUHJvdG9jb2xiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.SL_ChatWriteLogCommand), global::Google.Protobuf.ClusterProtocol.SL_ChatWriteLogCommand.Parser, new[]{ "Chat" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.SL_ChatReadLogQuery), global::Google.Protobuf.ClusterProtocol.SL_ChatReadLogQuery.Parser, new[]{ "RoomId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.LS_ChatReadLogResponse), global::Google.Protobuf.ClusterProtocol.LS_ChatReadLogResponse.Parser, new[]{ "Chats" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.ChatObject), global::Google.Protobuf.ClusterProtocol.ChatObject.Parser, new[]{ "ObjectId", "RoomId", "Chat", "Time", "AccoutnName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.AS_GetAllRoomInfoQuery), global::Google.Protobuf.ClusterProtocol.AS_GetAllRoomInfoQuery.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.SA_GetAllRoomInfoResponse), global::Google.Protobuf.ClusterProtocol.SA_GetAllRoomInfoResponse.Parser, new[]{ "RoomInfos" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.ClusterProtocol.RoomInfo), global::Google.Protobuf.ClusterProtocol.RoomInfo.Parser, new[]{ "RoomID", "MaxCount", "CurrentCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SL_ChatWriteLogCommand : pb::IMessage<SL_ChatWriteLogCommand> {
    private static readonly pb::MessageParser<SL_ChatWriteLogCommand> _parser = new pb::MessageParser<SL_ChatWriteLogCommand>(() => new SL_ChatWriteLogCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SL_ChatWriteLogCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLogCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLogCommand(SL_ChatWriteLogCommand other) : this() {
      chat_ = other.chat_ != null ? other.chat_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatWriteLogCommand Clone() {
      return new SL_ChatWriteLogCommand(this);
    }

    /// <summary>Field number for the "Chat" field.</summary>
    public const int ChatFieldNumber = 1;
    private global::Google.Protobuf.ClusterProtocol.ChatObject chat_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.ClusterProtocol.ChatObject Chat {
      get { return chat_; }
      set {
        chat_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SL_ChatWriteLogCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SL_ChatWriteLogCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Chat, other.Chat)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (chat_ != null) hash ^= Chat.GetHashCode();
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
      if (chat_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Chat);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (chat_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Chat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SL_ChatWriteLogCommand other) {
      if (other == null) {
        return;
      }
      if (other.chat_ != null) {
        if (chat_ == null) {
          Chat = new global::Google.Protobuf.ClusterProtocol.ChatObject();
        }
        Chat.MergeFrom(other.Chat);
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
            if (chat_ == null) {
              Chat = new global::Google.Protobuf.ClusterProtocol.ChatObject();
            }
            input.ReadMessage(Chat);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SL_ChatReadLogQuery : pb::IMessage<SL_ChatReadLogQuery> {
    private static readonly pb::MessageParser<SL_ChatReadLogQuery> _parser = new pb::MessageParser<SL_ChatReadLogQuery>(() => new SL_ChatReadLogQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SL_ChatReadLogQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLogQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLogQuery(SL_ChatReadLogQuery other) : this() {
      roomId_ = other.roomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SL_ChatReadLogQuery Clone() {
      return new SL_ChatReadLogQuery(this);
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SL_ChatReadLogQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SL_ChatReadLogQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
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
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SL_ChatReadLogQuery other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
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
          case 8: {
            RoomId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LS_ChatReadLogResponse : pb::IMessage<LS_ChatReadLogResponse> {
    private static readonly pb::MessageParser<LS_ChatReadLogResponse> _parser = new pb::MessageParser<LS_ChatReadLogResponse>(() => new LS_ChatReadLogResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LS_ChatReadLogResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLogResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLogResponse(LS_ChatReadLogResponse other) : this() {
      chats_ = other.chats_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LS_ChatReadLogResponse Clone() {
      return new LS_ChatReadLogResponse(this);
    }

    /// <summary>Field number for the "chats" field.</summary>
    public const int ChatsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.ClusterProtocol.ChatObject> _repeated_chats_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.ClusterProtocol.ChatObject.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject> chats_ = new pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.ChatObject> Chats {
      get { return chats_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LS_ChatReadLogResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LS_ChatReadLogResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chats_.Equals(other.chats_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chats_.GetHashCode();
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
      chats_.WriteTo(output, _repeated_chats_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += chats_.CalculateSize(_repeated_chats_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LS_ChatReadLogResponse other) {
      if (other == null) {
        return;
      }
      chats_.Add(other.chats_);
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
            chats_.AddEntriesFrom(input, _repeated_chats_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatObject : pb::IMessage<ChatObject> {
    private static readonly pb::MessageParser<ChatObject> _parser = new pb::MessageParser<ChatObject>(() => new ChatObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject(ChatObject other) : this() {
      objectId_ = other.objectId_;
      roomId_ = other.roomId_;
      chat_ = other.chat_;
      time_ = other.time_ != null ? other.time_.Clone() : null;
      accoutnName_ = other.accoutnName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatObject Clone() {
      return new ChatObject(this);
    }

    /// <summary>Field number for the "objectId" field.</summary>
    public const int ObjectIdFieldNumber = 1;
    private int objectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    /// <summary>Field number for the "roomId" field.</summary>
    public const int RoomIdFieldNumber = 2;
    private int roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "chat" field.</summary>
    public const int ChatFieldNumber = 3;
    private string chat_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Chat {
      get { return chat_; }
      set {
        chat_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "accoutnName" field.</summary>
    public const int AccoutnNameFieldNumber = 5;
    private string accoutnName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AccoutnName {
      get { return accoutnName_; }
      set {
        accoutnName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ObjectId != other.ObjectId) return false;
      if (RoomId != other.RoomId) return false;
      if (Chat != other.Chat) return false;
      if (!object.Equals(Time, other.Time)) return false;
      if (AccoutnName != other.AccoutnName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ObjectId != 0) hash ^= ObjectId.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (Chat.Length != 0) hash ^= Chat.GetHashCode();
      if (time_ != null) hash ^= Time.GetHashCode();
      if (AccoutnName.Length != 0) hash ^= AccoutnName.GetHashCode();
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
      if (ObjectId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ObjectId);
      }
      if (RoomId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RoomId);
      }
      if (Chat.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Chat);
      }
      if (time_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Time);
      }
      if (AccoutnName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AccoutnName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ObjectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectId);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (Chat.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Chat);
      }
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      if (AccoutnName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccoutnName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatObject other) {
      if (other == null) {
        return;
      }
      if (other.ObjectId != 0) {
        ObjectId = other.ObjectId;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.Chat.Length != 0) {
        Chat = other.Chat;
      }
      if (other.time_ != null) {
        if (time_ == null) {
          Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Time.MergeFrom(other.Time);
      }
      if (other.AccoutnName.Length != 0) {
        AccoutnName = other.AccoutnName;
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
          case 8: {
            ObjectId = input.ReadInt32();
            break;
          }
          case 16: {
            RoomId = input.ReadInt32();
            break;
          }
          case 26: {
            Chat = input.ReadString();
            break;
          }
          case 34: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 42: {
            AccoutnName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AS_GetAllRoomInfoQuery : pb::IMessage<AS_GetAllRoomInfoQuery> {
    private static readonly pb::MessageParser<AS_GetAllRoomInfoQuery> _parser = new pb::MessageParser<AS_GetAllRoomInfoQuery>(() => new AS_GetAllRoomInfoQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AS_GetAllRoomInfoQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AS_GetAllRoomInfoQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AS_GetAllRoomInfoQuery(AS_GetAllRoomInfoQuery other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AS_GetAllRoomInfoQuery Clone() {
      return new AS_GetAllRoomInfoQuery(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AS_GetAllRoomInfoQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AS_GetAllRoomInfoQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AS_GetAllRoomInfoQuery other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class SA_GetAllRoomInfoResponse : pb::IMessage<SA_GetAllRoomInfoResponse> {
    private static readonly pb::MessageParser<SA_GetAllRoomInfoResponse> _parser = new pb::MessageParser<SA_GetAllRoomInfoResponse>(() => new SA_GetAllRoomInfoResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SA_GetAllRoomInfoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SA_GetAllRoomInfoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SA_GetAllRoomInfoResponse(SA_GetAllRoomInfoResponse other) : this() {
      roomInfos_ = other.roomInfos_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SA_GetAllRoomInfoResponse Clone() {
      return new SA_GetAllRoomInfoResponse(this);
    }

    /// <summary>Field number for the "roomInfos" field.</summary>
    public const int RoomInfosFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.ClusterProtocol.RoomInfo> _repeated_roomInfos_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.ClusterProtocol.RoomInfo.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.RoomInfo> roomInfos_ = new pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.RoomInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.ClusterProtocol.RoomInfo> RoomInfos {
      get { return roomInfos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SA_GetAllRoomInfoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SA_GetAllRoomInfoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!roomInfos_.Equals(other.roomInfos_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= roomInfos_.GetHashCode();
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
      roomInfos_.WriteTo(output, _repeated_roomInfos_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += roomInfos_.CalculateSize(_repeated_roomInfos_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SA_GetAllRoomInfoResponse other) {
      if (other == null) {
        return;
      }
      roomInfos_.Add(other.roomInfos_);
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
            roomInfos_.AddEntriesFrom(input, _repeated_roomInfos_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoomInfo : pb::IMessage<RoomInfo> {
    private static readonly pb::MessageParser<RoomInfo> _parser = new pb::MessageParser<RoomInfo>(() => new RoomInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.ClusterProtocol.ClusterProtocolReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo(RoomInfo other) : this() {
      roomID_ = other.roomID_;
      maxCount_ = other.maxCount_;
      currentCount_ = other.currentCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo Clone() {
      return new RoomInfo(this);
    }

    /// <summary>Field number for the "roomID" field.</summary>
    public const int RoomIDFieldNumber = 1;
    private int roomID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomID {
      get { return roomID_; }
      set {
        roomID_ = value;
      }
    }

    /// <summary>Field number for the "maxCount" field.</summary>
    public const int MaxCountFieldNumber = 2;
    private int maxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxCount {
      get { return maxCount_; }
      set {
        maxCount_ = value;
      }
    }

    /// <summary>Field number for the "currentCount" field.</summary>
    public const int CurrentCountFieldNumber = 3;
    private int currentCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentCount {
      get { return currentCount_; }
      set {
        currentCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomID != other.RoomID) return false;
      if (MaxCount != other.MaxCount) return false;
      if (CurrentCount != other.CurrentCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomID != 0) hash ^= RoomID.GetHashCode();
      if (MaxCount != 0) hash ^= MaxCount.GetHashCode();
      if (CurrentCount != 0) hash ^= CurrentCount.GetHashCode();
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
      if (RoomID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomID);
      }
      if (MaxCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxCount);
      }
      if (CurrentCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CurrentCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomID);
      }
      if (MaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxCount);
      }
      if (CurrentCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomInfo other) {
      if (other == null) {
        return;
      }
      if (other.RoomID != 0) {
        RoomID = other.RoomID;
      }
      if (other.MaxCount != 0) {
        MaxCount = other.MaxCount;
      }
      if (other.CurrentCount != 0) {
        CurrentCount = other.CurrentCount;
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
          case 8: {
            RoomID = input.ReadInt32();
            break;
          }
          case 16: {
            MaxCount = input.ReadInt32();
            break;
          }
          case 24: {
            CurrentCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
