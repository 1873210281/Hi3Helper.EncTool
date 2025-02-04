// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StarRailDispatch.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Hi3Helper.EncTool.Proto.StarRail {

  /// <summary>Holder for reflection information generated from StarRailDispatch.proto</summary>
  public static partial class StarRailDispatchReflection {

    #region Descriptor
    /// <summary>File descriptor for StarRailDispatch.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StarRailDispatchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTdGFyUmFpbERpc3BhdGNoLnByb3RvEiBIaTNIZWxwZXIuRW5jVG9vbC5Q",
            "cm90by5TdGFyUmFpbCJTChBTdGFyUmFpbERpc3BhdGNoEj8KCEdhdGV3YXlz",
            "GAQgAygLMi0uSGkzSGVscGVyLkVuY1Rvb2wuUHJvdG8uU3RhclJhaWwuR2F0",
            "ZXdheUluZm8iZAoLR2F0ZXdheUluZm8SDAoETmFtZRgBIAEoCRIMCgRIb3N0",
            "GAMgASgJEg8KB1Vua25vd24YBCABKAkSEgoKUmVnaW9uTmFtZRgFIAEoCRIU",
            "CgxvZ2luV2hpdGVNc2cYBiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Hi3Helper.EncTool.Proto.StarRail.StarRailDispatch), global::Hi3Helper.EncTool.Proto.StarRail.StarRailDispatch.Parser, new[]{ "Gateways" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo), global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo.Parser, new[]{ "Name", "Host", "Unknown", "RegionName", "OginWhiteMsg" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StarRailDispatch : pb::IMessage<StarRailDispatch>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StarRailDispatch> _parser = new pb::MessageParser<StarRailDispatch>(() => new StarRailDispatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StarRailDispatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Hi3Helper.EncTool.Proto.StarRail.StarRailDispatchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarRailDispatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarRailDispatch(StarRailDispatch other) : this() {
      gateways_ = other.gateways_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StarRailDispatch Clone() {
      return new StarRailDispatch(this);
    }

    /// <summary>Field number for the "Gateways" field.</summary>
    public const int GatewaysFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo> _repeated_gateways_codec
        = pb::FieldCodec.ForMessage(34, global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo.Parser);
    private readonly pbc::RepeatedField<global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo> gateways_ = new pbc::RepeatedField<global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Hi3Helper.EncTool.Proto.StarRail.GatewayInfo> Gateways {
      get { return gateways_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StarRailDispatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StarRailDispatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gateways_.Equals(other.gateways_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gateways_.GetHashCode();
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
      gateways_.WriteTo(output, _repeated_gateways_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      gateways_.WriteTo(ref output, _repeated_gateways_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += gateways_.CalculateSize(_repeated_gateways_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StarRailDispatch other) {
      if (other == null) {
        return;
      }
      gateways_.Add(other.gateways_);
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
          case 34: {
            gateways_.AddEntriesFrom(input, _repeated_gateways_codec);
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
          case 34: {
            gateways_.AddEntriesFrom(ref input, _repeated_gateways_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GatewayInfo : pb::IMessage<GatewayInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GatewayInfo> _parser = new pb::MessageParser<GatewayInfo>(() => new GatewayInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GatewayInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Hi3Helper.EncTool.Proto.StarRail.StarRailDispatchReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GatewayInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GatewayInfo(GatewayInfo other) : this() {
      name_ = other.name_;
      host_ = other.host_;
      unknown_ = other.unknown_;
      regionName_ = other.regionName_;
      oginWhiteMsg_ = other.oginWhiteMsg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GatewayInfo Clone() {
      return new GatewayInfo(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Host" field.</summary>
    public const int HostFieldNumber = 3;
    private string host_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unknown" field.</summary>
    public const int UnknownFieldNumber = 4;
    private string unknown_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unknown {
      get { return unknown_; }
      set {
        unknown_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "RegionName" field.</summary>
    public const int RegionNameFieldNumber = 5;
    private string regionName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RegionName {
      get { return regionName_; }
      set {
        regionName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "oginWhiteMsg" field.</summary>
    public const int OginWhiteMsgFieldNumber = 6;
    private string oginWhiteMsg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OginWhiteMsg {
      get { return oginWhiteMsg_; }
      set {
        oginWhiteMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GatewayInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GatewayInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Host != other.Host) return false;
      if (Unknown != other.Unknown) return false;
      if (RegionName != other.RegionName) return false;
      if (OginWhiteMsg != other.OginWhiteMsg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (Unknown.Length != 0) hash ^= Unknown.GetHashCode();
      if (RegionName.Length != 0) hash ^= RegionName.GetHashCode();
      if (OginWhiteMsg.Length != 0) hash ^= OginWhiteMsg.GetHashCode();
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
      if (Host.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Host);
      }
      if (Unknown.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Unknown);
      }
      if (RegionName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RegionName);
      }
      if (OginWhiteMsg.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OginWhiteMsg);
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
      if (Host.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Host);
      }
      if (Unknown.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Unknown);
      }
      if (RegionName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RegionName);
      }
      if (OginWhiteMsg.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OginWhiteMsg);
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
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (Unknown.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unknown);
      }
      if (RegionName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegionName);
      }
      if (OginWhiteMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OginWhiteMsg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GatewayInfo other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.Unknown.Length != 0) {
        Unknown = other.Unknown;
      }
      if (other.RegionName.Length != 0) {
        RegionName = other.RegionName;
      }
      if (other.OginWhiteMsg.Length != 0) {
        OginWhiteMsg = other.OginWhiteMsg;
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
          case 26: {
            Host = input.ReadString();
            break;
          }
          case 34: {
            Unknown = input.ReadString();
            break;
          }
          case 42: {
            RegionName = input.ReadString();
            break;
          }
          case 50: {
            OginWhiteMsg = input.ReadString();
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
          case 26: {
            Host = input.ReadString();
            break;
          }
          case 34: {
            Unknown = input.ReadString();
            break;
          }
          case 42: {
            RegionName = input.ReadString();
            break;
          }
          case 50: {
            OginWhiteMsg = input.ReadString();
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
