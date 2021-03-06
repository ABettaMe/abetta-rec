// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Experiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Experiment.proto</summary>
public static partial class ExperimentReflection {

  #region Descriptor
  /// <summary>File descriptor for Experiment.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ExperimentReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBFeHBlcmltZW50LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1w",
          "LnByb3RvGgxNZXRyaWMucHJvdG8aFFJlY29tbWVuZGF0aW9uLnByb3RvIogD",
          "CgpFeHBlcmltZW50EgoKAmlkGAEgASgJEgwKBG5hbWUYAiABKAkSGwoTZGVz",
          "Y3JpcHRpb25fY29udHJvbBgDIAEoCRIgCg9tZXRyaWNzX2NvbnRyb2wYBCAD",
          "KAsyBy5NZXRyaWMSIgoRbWV0cmljc190cmVhdG1lbnQYBSADKAsyBy5NZXRy",
          "aWMSKwoHY3JlYXRlZBgGIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
          "bXASLQoJY29tcGxldGVkGAcgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
          "dGFtcBIiCgZzdGF0dXMYCCABKA4yEi5FeHBlcmltZW50LlN0YXR1cxIdChVk",
          "ZXNjcmlwdGlvbl90cmVhdG1lbnQYCSABKAkSKAoPcmVjb21tZW5kYXRpb25z",
          "GAogAygLMg8uUmVjb21tZW5kYXRpb24iNAoGU3RhdHVzEg8KC05PVF9TVEFS",
          "VEVEEAASCgoGQUNUSVZFEAESDQoJQ09NUExFVEVEEAJiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::MetricReflection.Descriptor, global::RecommendationReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Experiment), global::Experiment.Parser, new[]{ "Id", "Name", "DescriptionControl", "MetricsControl", "MetricsTreatment", "Created", "Completed", "Status", "DescriptionTreatment", "Recommendations" }, null, new[]{ typeof(global::Experiment.Types.Status) }, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Experiment : pb::IMessage<Experiment>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Experiment> _parser = new pb::MessageParser<Experiment>(() => new Experiment());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Experiment> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExperimentReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Experiment() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Experiment(Experiment other) : this() {
    id_ = other.id_;
    name_ = other.name_;
    descriptionControl_ = other.descriptionControl_;
    metricsControl_ = other.metricsControl_.Clone();
    metricsTreatment_ = other.metricsTreatment_.Clone();
    created_ = other.created_ != null ? other.created_.Clone() : null;
    completed_ = other.completed_ != null ? other.completed_.Clone() : null;
    status_ = other.status_;
    descriptionTreatment_ = other.descriptionTreatment_;
    recommendations_ = other.recommendations_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Experiment Clone() {
    return new Experiment(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private string id_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Id {
    get { return id_; }
    set {
      id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 2;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "description_control" field.</summary>
  public const int DescriptionControlFieldNumber = 3;
  private string descriptionControl_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string DescriptionControl {
    get { return descriptionControl_; }
    set {
      descriptionControl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "metrics_control" field.</summary>
  public const int MetricsControlFieldNumber = 4;
  private static readonly pb::FieldCodec<global::Metric> _repeated_metricsControl_codec
      = pb::FieldCodec.ForMessage(34, global::Metric.Parser);
  private readonly pbc::RepeatedField<global::Metric> metricsControl_ = new pbc::RepeatedField<global::Metric>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Metric> MetricsControl {
    get { return metricsControl_; }
  }

  /// <summary>Field number for the "metrics_treatment" field.</summary>
  public const int MetricsTreatmentFieldNumber = 5;
  private static readonly pb::FieldCodec<global::Metric> _repeated_metricsTreatment_codec
      = pb::FieldCodec.ForMessage(42, global::Metric.Parser);
  private readonly pbc::RepeatedField<global::Metric> metricsTreatment_ = new pbc::RepeatedField<global::Metric>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Metric> MetricsTreatment {
    get { return metricsTreatment_; }
  }

  /// <summary>Field number for the "created" field.</summary>
  public const int CreatedFieldNumber = 6;
  private global::Google.Protobuf.WellKnownTypes.Timestamp created_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Google.Protobuf.WellKnownTypes.Timestamp Created {
    get { return created_; }
    set {
      created_ = value;
    }
  }

  /// <summary>Field number for the "completed" field.</summary>
  public const int CompletedFieldNumber = 7;
  private global::Google.Protobuf.WellKnownTypes.Timestamp completed_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Google.Protobuf.WellKnownTypes.Timestamp Completed {
    get { return completed_; }
    set {
      completed_ = value;
    }
  }

  /// <summary>Field number for the "status" field.</summary>
  public const int StatusFieldNumber = 8;
  private global::Experiment.Types.Status status_ = global::Experiment.Types.Status.NotStarted;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Experiment.Types.Status Status {
    get { return status_; }
    set {
      status_ = value;
    }
  }

  /// <summary>Field number for the "description_treatment" field.</summary>
  public const int DescriptionTreatmentFieldNumber = 9;
  private string descriptionTreatment_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string DescriptionTreatment {
    get { return descriptionTreatment_; }
    set {
      descriptionTreatment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "recommendations" field.</summary>
  public const int RecommendationsFieldNumber = 10;
  private static readonly pb::FieldCodec<global::Recommendation> _repeated_recommendations_codec
      = pb::FieldCodec.ForMessage(82, global::Recommendation.Parser);
  private readonly pbc::RepeatedField<global::Recommendation> recommendations_ = new pbc::RepeatedField<global::Recommendation>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Recommendation> Recommendations {
    get { return recommendations_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Experiment);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Experiment other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Name != other.Name) return false;
    if (DescriptionControl != other.DescriptionControl) return false;
    if(!metricsControl_.Equals(other.metricsControl_)) return false;
    if(!metricsTreatment_.Equals(other.metricsTreatment_)) return false;
    if (!object.Equals(Created, other.Created)) return false;
    if (!object.Equals(Completed, other.Completed)) return false;
    if (Status != other.Status) return false;
    if (DescriptionTreatment != other.DescriptionTreatment) return false;
    if(!recommendations_.Equals(other.recommendations_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id.Length != 0) hash ^= Id.GetHashCode();
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (DescriptionControl.Length != 0) hash ^= DescriptionControl.GetHashCode();
    hash ^= metricsControl_.GetHashCode();
    hash ^= metricsTreatment_.GetHashCode();
    if (created_ != null) hash ^= Created.GetHashCode();
    if (completed_ != null) hash ^= Completed.GetHashCode();
    if (Status != global::Experiment.Types.Status.NotStarted) hash ^= Status.GetHashCode();
    if (DescriptionTreatment.Length != 0) hash ^= DescriptionTreatment.GetHashCode();
    hash ^= recommendations_.GetHashCode();
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
    if (Id.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (DescriptionControl.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(DescriptionControl);
    }
    metricsControl_.WriteTo(output, _repeated_metricsControl_codec);
    metricsTreatment_.WriteTo(output, _repeated_metricsTreatment_codec);
    if (created_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(Created);
    }
    if (completed_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Completed);
    }
    if (Status != global::Experiment.Types.Status.NotStarted) {
      output.WriteRawTag(64);
      output.WriteEnum((int) Status);
    }
    if (DescriptionTreatment.Length != 0) {
      output.WriteRawTag(74);
      output.WriteString(DescriptionTreatment);
    }
    recommendations_.WriteTo(output, _repeated_recommendations_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Id.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (Name.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Name);
    }
    if (DescriptionControl.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(DescriptionControl);
    }
    metricsControl_.WriteTo(ref output, _repeated_metricsControl_codec);
    metricsTreatment_.WriteTo(ref output, _repeated_metricsTreatment_codec);
    if (created_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(Created);
    }
    if (completed_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Completed);
    }
    if (Status != global::Experiment.Types.Status.NotStarted) {
      output.WriteRawTag(64);
      output.WriteEnum((int) Status);
    }
    if (DescriptionTreatment.Length != 0) {
      output.WriteRawTag(74);
      output.WriteString(DescriptionTreatment);
    }
    recommendations_.WriteTo(ref output, _repeated_recommendations_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
    }
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (DescriptionControl.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(DescriptionControl);
    }
    size += metricsControl_.CalculateSize(_repeated_metricsControl_codec);
    size += metricsTreatment_.CalculateSize(_repeated_metricsTreatment_codec);
    if (created_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Created);
    }
    if (completed_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Completed);
    }
    if (Status != global::Experiment.Types.Status.NotStarted) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
    }
    if (DescriptionTreatment.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(DescriptionTreatment);
    }
    size += recommendations_.CalculateSize(_repeated_recommendations_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Experiment other) {
    if (other == null) {
      return;
    }
    if (other.Id.Length != 0) {
      Id = other.Id;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.DescriptionControl.Length != 0) {
      DescriptionControl = other.DescriptionControl;
    }
    metricsControl_.Add(other.metricsControl_);
    metricsTreatment_.Add(other.metricsTreatment_);
    if (other.created_ != null) {
      if (created_ == null) {
        Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
      }
      Created.MergeFrom(other.Created);
    }
    if (other.completed_ != null) {
      if (completed_ == null) {
        Completed = new global::Google.Protobuf.WellKnownTypes.Timestamp();
      }
      Completed.MergeFrom(other.Completed);
    }
    if (other.Status != global::Experiment.Types.Status.NotStarted) {
      Status = other.Status;
    }
    if (other.DescriptionTreatment.Length != 0) {
      DescriptionTreatment = other.DescriptionTreatment;
    }
    recommendations_.Add(other.recommendations_);
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
          Id = input.ReadString();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 26: {
          DescriptionControl = input.ReadString();
          break;
        }
        case 34: {
          metricsControl_.AddEntriesFrom(input, _repeated_metricsControl_codec);
          break;
        }
        case 42: {
          metricsTreatment_.AddEntriesFrom(input, _repeated_metricsTreatment_codec);
          break;
        }
        case 50: {
          if (created_ == null) {
            Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Created);
          break;
        }
        case 58: {
          if (completed_ == null) {
            Completed = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Completed);
          break;
        }
        case 64: {
          Status = (global::Experiment.Types.Status) input.ReadEnum();
          break;
        }
        case 74: {
          DescriptionTreatment = input.ReadString();
          break;
        }
        case 82: {
          recommendations_.AddEntriesFrom(input, _repeated_recommendations_codec);
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
          Id = input.ReadString();
          break;
        }
        case 18: {
          Name = input.ReadString();
          break;
        }
        case 26: {
          DescriptionControl = input.ReadString();
          break;
        }
        case 34: {
          metricsControl_.AddEntriesFrom(ref input, _repeated_metricsControl_codec);
          break;
        }
        case 42: {
          metricsTreatment_.AddEntriesFrom(ref input, _repeated_metricsTreatment_codec);
          break;
        }
        case 50: {
          if (created_ == null) {
            Created = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Created);
          break;
        }
        case 58: {
          if (completed_ == null) {
            Completed = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Completed);
          break;
        }
        case 64: {
          Status = (global::Experiment.Types.Status) input.ReadEnum();
          break;
        }
        case 74: {
          DescriptionTreatment = input.ReadString();
          break;
        }
        case 82: {
          recommendations_.AddEntriesFrom(ref input, _repeated_recommendations_codec);
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the Experiment message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum Status {
      [pbr::OriginalName("NOT_STARTED")] NotStarted = 0,
      [pbr::OriginalName("ACTIVE")] Active = 1,
      [pbr::OriginalName("COMPLETED")] Completed = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
