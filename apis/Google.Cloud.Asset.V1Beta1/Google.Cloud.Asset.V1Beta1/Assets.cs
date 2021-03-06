// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/asset/v1beta1/assets.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Asset.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/asset/v1beta1/assets.proto</summary>
  public static partial class AssetsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/asset/v1beta1/assets.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidnb29nbGUvY2xvdWQvYXNzZXQvdjFiZXRhMS9hc3NldHMucHJvdG8SGmdv",
            "b2dsZS5jbG91ZC5hc3NldC52MWJldGExGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvGhpnb29nbGUvaWFtL3YxL3BvbGljeS5wcm90bxoZZ29vZ2xl",
            "L3Byb3RvYnVmL2FueS5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5w",
            "cm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKKAQoNVGVt",
            "cG9yYWxBc3NldBI2CgZ3aW5kb3cYASABKAsyJi5nb29nbGUuY2xvdWQuYXNz",
            "ZXQudjFiZXRhMS5UaW1lV2luZG93Eg8KB2RlbGV0ZWQYAiABKAgSMAoFYXNz",
            "ZXQYAyABKAsyIS5nb29nbGUuY2xvdWQuYXNzZXQudjFiZXRhMS5Bc3NldCJq",
            "CgpUaW1lV2luZG93Ei4KCnN0YXJ0X3RpbWUYASABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wEiwKCGVuZF90aW1lGAIgASgLMhouZ29vZ2xlLnBy",
            "b3RvYnVmLlRpbWVzdGFtcCKMAQoFQXNzZXQSDAoEbmFtZRgBIAEoCRISCgph",
            "c3NldF90eXBlGAIgASgJEjYKCHJlc291cmNlGAMgASgLMiQuZ29vZ2xlLmNs",
            "b3VkLmFzc2V0LnYxYmV0YTEuUmVzb3VyY2USKQoKaWFtX3BvbGljeRgEIAEo",
            "CzIVLmdvb2dsZS5pYW0udjEuUG9saWN5IqABCghSZXNvdXJjZRIPCgd2ZXJz",
            "aW9uGAEgASgJEh4KFmRpc2NvdmVyeV9kb2N1bWVudF91cmkYAiABKAkSFgoO",
            "ZGlzY292ZXJ5X25hbWUYAyABKAkSFAoMcmVzb3VyY2VfdXJsGAQgASgJEg4K",
            "BnBhcmVudBgFIAEoCRIlCgRkYXRhGAYgASgLMhcuZ29vZ2xlLnByb3RvYnVm",
            "LlN0cnVjdEKpAQoeY29tLmdvb2dsZS5jbG91ZC5hc3NldC52MWJldGExQgpB",
            "c3NldFByb3RvUAFaP2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvYXNzZXQvdjFiZXRhMTthc3NldKoCGkdvb2dsZS5DbG91",
            "ZC5Bc3NldC5WMUJldGExygIaR29vZ2xlXENsb3VkXEFzc2V0XFYxYmV0YTFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Iam.V1.PolicyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Asset.V1Beta1.TemporalAsset), global::Google.Cloud.Asset.V1Beta1.TemporalAsset.Parser, new[]{ "Window", "Deleted", "Asset" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Asset.V1Beta1.TimeWindow), global::Google.Cloud.Asset.V1Beta1.TimeWindow.Parser, new[]{ "StartTime", "EndTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Asset.V1Beta1.Asset), global::Google.Cloud.Asset.V1Beta1.Asset.Parser, new[]{ "Name", "AssetType", "Resource", "IamPolicy" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Asset.V1Beta1.Resource), global::Google.Cloud.Asset.V1Beta1.Resource.Parser, new[]{ "Version", "DiscoveryDocumentUri", "DiscoveryName", "ResourceUrl", "Parent", "Data" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Temporal asset. In addition to the asset, the temporal asset includes the
  /// status of the asset and valid from and to time of it.
  /// </summary>
  public sealed partial class TemporalAsset : pb::IMessage<TemporalAsset> {
    private static readonly pb::MessageParser<TemporalAsset> _parser = new pb::MessageParser<TemporalAsset>(() => new TemporalAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TemporalAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Asset.V1Beta1.AssetsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TemporalAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TemporalAsset(TemporalAsset other) : this() {
      window_ = other.window_ != null ? other.window_.Clone() : null;
      deleted_ = other.deleted_;
      asset_ = other.asset_ != null ? other.asset_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TemporalAsset Clone() {
      return new TemporalAsset(this);
    }

    /// <summary>Field number for the "window" field.</summary>
    public const int WindowFieldNumber = 1;
    private global::Google.Cloud.Asset.V1Beta1.TimeWindow window_;
    /// <summary>
    /// The time window when the asset data and state was observed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Asset.V1Beta1.TimeWindow Window {
      get { return window_; }
      set {
        window_ = value;
      }
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 2;
    private bool deleted_;
    /// <summary>
    /// If the asset is deleted or not.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 3;
    private global::Google.Cloud.Asset.V1Beta1.Asset asset_;
    /// <summary>
    /// Asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Asset.V1Beta1.Asset Asset {
      get { return asset_; }
      set {
        asset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TemporalAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TemporalAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Window, other.Window)) return false;
      if (Deleted != other.Deleted) return false;
      if (!object.Equals(Asset, other.Asset)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (window_ != null) hash ^= Window.GetHashCode();
      if (Deleted != false) hash ^= Deleted.GetHashCode();
      if (asset_ != null) hash ^= Asset.GetHashCode();
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
      if (window_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Window);
      }
      if (Deleted != false) {
        output.WriteRawTag(16);
        output.WriteBool(Deleted);
      }
      if (asset_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (window_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Window);
      }
      if (Deleted != false) {
        size += 1 + 1;
      }
      if (asset_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Asset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TemporalAsset other) {
      if (other == null) {
        return;
      }
      if (other.window_ != null) {
        if (window_ == null) {
          window_ = new global::Google.Cloud.Asset.V1Beta1.TimeWindow();
        }
        Window.MergeFrom(other.Window);
      }
      if (other.Deleted != false) {
        Deleted = other.Deleted;
      }
      if (other.asset_ != null) {
        if (asset_ == null) {
          asset_ = new global::Google.Cloud.Asset.V1Beta1.Asset();
        }
        Asset.MergeFrom(other.Asset);
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
            if (window_ == null) {
              window_ = new global::Google.Cloud.Asset.V1Beta1.TimeWindow();
            }
            input.ReadMessage(window_);
            break;
          }
          case 16: {
            Deleted = input.ReadBool();
            break;
          }
          case 26: {
            if (asset_ == null) {
              asset_ = new global::Google.Cloud.Asset.V1Beta1.Asset();
            }
            input.ReadMessage(asset_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A time window of [start_time, end_time).
  /// </summary>
  public sealed partial class TimeWindow : pb::IMessage<TimeWindow> {
    private static readonly pb::MessageParser<TimeWindow> _parser = new pb::MessageParser<TimeWindow>(() => new TimeWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Asset.V1Beta1.AssetsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeWindow(TimeWindow other) : this() {
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      endTime_ = other.endTime_ != null ? other.endTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeWindow Clone() {
      return new TimeWindow(this);
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startTime_;
    /// <summary>
    /// Start time of the time window (inclusive).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp endTime_;
    /// <summary>
    /// End time of the time window (exclusive).
    /// Current timestamp if not specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeWindow other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(EndTime, other.EndTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (endTime_ != null) hash ^= EndTime.GetHashCode();
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
      if (startTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (endTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EndTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (endTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeWindow other) {
      if (other == null) {
        return;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          startTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.endTime_ != null) {
        if (endTime_ == null) {
          endTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EndTime.MergeFrom(other.EndTime);
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
            if (startTime_ == null) {
              startTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(startTime_);
            break;
          }
          case 18: {
            if (endTime_ == null) {
              endTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(endTime_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Cloud asset. This includes all Google Cloud Platform resources,
  /// Cloud IAM policies, and other non-GCP assets.
  /// </summary>
  public sealed partial class Asset : pb::IMessage<Asset> {
    private static readonly pb::MessageParser<Asset> _parser = new pb::MessageParser<Asset>(() => new Asset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Asset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Asset.V1Beta1.AssetsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset(Asset other) : this() {
      name_ = other.name_;
      assetType_ = other.assetType_;
      resource_ = other.resource_ != null ? other.resource_.Clone() : null;
      iamPolicy_ = other.iamPolicy_ != null ? other.iamPolicy_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset Clone() {
      return new Asset(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The full name of the asset. For example: `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
    /// See [Resource Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
    /// for more information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_type" field.</summary>
    public const int AssetTypeFieldNumber = 2;
    private string assetType_ = "";
    /// <summary>
    /// Type of the asset. Example: "google.compute.disk".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AssetType {
      get { return assetType_; }
      set {
        assetType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 3;
    private global::Google.Cloud.Asset.V1Beta1.Resource resource_;
    /// <summary>
    /// Representation of the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Asset.V1Beta1.Resource Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    /// <summary>Field number for the "iam_policy" field.</summary>
    public const int IamPolicyFieldNumber = 4;
    private global::Google.Cloud.Iam.V1.Policy iamPolicy_;
    /// <summary>
    /// Representation of the actual Cloud IAM policy set on a cloud resource. For each
    /// resource, there must be at most one Cloud IAM policy set on it.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Iam.V1.Policy IamPolicy {
      get { return iamPolicy_; }
      set {
        iamPolicy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Asset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Asset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (AssetType != other.AssetType) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      if (!object.Equals(IamPolicy, other.IamPolicy)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (AssetType.Length != 0) hash ^= AssetType.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
      if (iamPolicy_ != null) hash ^= IamPolicy.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (AssetType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AssetType);
      }
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
      }
      if (iamPolicy_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IamPolicy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (AssetType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetType);
      }
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      if (iamPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IamPolicy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Asset other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.AssetType.Length != 0) {
        AssetType = other.AssetType;
      }
      if (other.resource_ != null) {
        if (resource_ == null) {
          resource_ = new global::Google.Cloud.Asset.V1Beta1.Resource();
        }
        Resource.MergeFrom(other.Resource);
      }
      if (other.iamPolicy_ != null) {
        if (iamPolicy_ == null) {
          iamPolicy_ = new global::Google.Cloud.Iam.V1.Policy();
        }
        IamPolicy.MergeFrom(other.IamPolicy);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            AssetType = input.ReadString();
            break;
          }
          case 26: {
            if (resource_ == null) {
              resource_ = new global::Google.Cloud.Asset.V1Beta1.Resource();
            }
            input.ReadMessage(resource_);
            break;
          }
          case 34: {
            if (iamPolicy_ == null) {
              iamPolicy_ = new global::Google.Cloud.Iam.V1.Policy();
            }
            input.ReadMessage(iamPolicy_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Representation of a cloud resource.
  /// </summary>
  public sealed partial class Resource : pb::IMessage<Resource> {
    private static readonly pb::MessageParser<Resource> _parser = new pb::MessageParser<Resource>(() => new Resource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Resource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Asset.V1Beta1.AssetsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource(Resource other) : this() {
      version_ = other.version_;
      discoveryDocumentUri_ = other.discoveryDocumentUri_;
      discoveryName_ = other.discoveryName_;
      resourceUrl_ = other.resourceUrl_;
      parent_ = other.parent_;
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Resource Clone() {
      return new Resource(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    /// <summary>
    /// The API version. Example: "v1".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "discovery_document_uri" field.</summary>
    public const int DiscoveryDocumentUriFieldNumber = 2;
    private string discoveryDocumentUri_ = "";
    /// <summary>
    /// The URL of the discovery document containing the resource's JSON schema.
    /// For example:
    /// `"https://www.googleapis.com/discovery/v1/apis/compute/v1/rest"`.
    /// It will be left unspecified for resources without a discovery-based API,
    /// such as Cloud Bigtable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DiscoveryDocumentUri {
      get { return discoveryDocumentUri_; }
      set {
        discoveryDocumentUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "discovery_name" field.</summary>
    public const int DiscoveryNameFieldNumber = 3;
    private string discoveryName_ = "";
    /// <summary>
    /// The JSON schema name listed in the discovery document.
    /// Example: "Project". It will be left unspecified for resources (such as
    /// Cloud Bigtable) without a discovery-based API.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DiscoveryName {
      get { return discoveryName_; }
      set {
        discoveryName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_url" field.</summary>
    public const int ResourceUrlFieldNumber = 4;
    private string resourceUrl_ = "";
    /// <summary>
    /// The REST URL for accessing the resource. An HTTP GET operation using this
    /// URL returns the resource itself.
    /// Example:
    /// `https://cloudresourcemanager.googleapis.com/v1/projects/my-project-123`.
    /// It will be left unspecified for resources without a REST API.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceUrl {
      get { return resourceUrl_; }
      set {
        resourceUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 5;
    private string parent_ = "";
    /// <summary>
    /// The full name of the immediate parent of this resource. See
    /// [Resource Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
    /// for more information.
    ///
    /// For GCP assets, it is the parent resource defined in the [Cloud IAM policy
    /// hierarchy](https://cloud.google.com/iam/docs/overview#policy_hierarchy).
    /// For example: `"//cloudresourcemanager.googleapis.com/projects/my_project_123"`.
    ///
    /// For third-party assets, it is up to the users to define.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Struct data_;
    /// <summary>
    /// The content of the resource, in which some sensitive fields are scrubbed
    /// away and may not be present.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Resource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Resource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (DiscoveryDocumentUri != other.DiscoveryDocumentUri) return false;
      if (DiscoveryName != other.DiscoveryName) return false;
      if (ResourceUrl != other.ResourceUrl) return false;
      if (Parent != other.Parent) return false;
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (DiscoveryDocumentUri.Length != 0) hash ^= DiscoveryDocumentUri.GetHashCode();
      if (DiscoveryName.Length != 0) hash ^= DiscoveryName.GetHashCode();
      if (ResourceUrl.Length != 0) hash ^= ResourceUrl.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
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
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (DiscoveryDocumentUri.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DiscoveryDocumentUri);
      }
      if (DiscoveryName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DiscoveryName);
      }
      if (ResourceUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ResourceUrl);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Parent);
      }
      if (data_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (DiscoveryDocumentUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DiscoveryDocumentUri);
      }
      if (DiscoveryName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DiscoveryName);
      }
      if (ResourceUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceUrl);
      }
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Resource other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.DiscoveryDocumentUri.Length != 0) {
        DiscoveryDocumentUri = other.DiscoveryDocumentUri;
      }
      if (other.DiscoveryName.Length != 0) {
        DiscoveryName = other.DiscoveryName;
      }
      if (other.ResourceUrl.Length != 0) {
        ResourceUrl = other.ResourceUrl;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
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
            Version = input.ReadString();
            break;
          }
          case 18: {
            DiscoveryDocumentUri = input.ReadString();
            break;
          }
          case 26: {
            DiscoveryName = input.ReadString();
            break;
          }
          case 34: {
            ResourceUrl = input.ReadString();
            break;
          }
          case 42: {
            Parent = input.ReadString();
            break;
          }
          case 50: {
            if (data_ == null) {
              data_ = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(data_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
