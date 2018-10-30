/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/metric.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api {

  /// <summary>Holder for reflection information generated from google/api/metric.proto</summary>
  public static partial class MetricReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/metric.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetricReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdnb29nbGUvYXBpL21ldHJpYy5wcm90bxIKZ29vZ2xlLmFwaRoWZ29vZ2xl",
            "L2FwaS9sYWJlbC5wcm90bxodZ29vZ2xlL2FwaS9sYXVuY2hfc3RhZ2UucHJv",
            "dG8aHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90byLKBQoQTWV0cmlj",
            "RGVzY3JpcHRvchIMCgRuYW1lGAEgASgJEgwKBHR5cGUYCCABKAkSKwoGbGFi",
            "ZWxzGAIgAygLMhsuZ29vZ2xlLmFwaS5MYWJlbERlc2NyaXB0b3ISPAoLbWV0",
            "cmljX2tpbmQYAyABKA4yJy5nb29nbGUuYXBpLk1ldHJpY0Rlc2NyaXB0b3Iu",
            "TWV0cmljS2luZBI6Cgp2YWx1ZV90eXBlGAQgASgOMiYuZ29vZ2xlLmFwaS5N",
            "ZXRyaWNEZXNjcmlwdG9yLlZhbHVlVHlwZRIMCgR1bml0GAUgASgJEhMKC2Rl",
            "c2NyaXB0aW9uGAYgASgJEhQKDGRpc3BsYXlfbmFtZRgHIAEoCRJHCghtZXRh",
            "ZGF0YRgKIAEoCzI1Lmdvb2dsZS5hcGkuTWV0cmljRGVzY3JpcHRvci5NZXRy",
            "aWNEZXNjcmlwdG9yTWV0YWRhdGEarAEKGE1ldHJpY0Rlc2NyaXB0b3JNZXRh",
            "ZGF0YRItCgxsYXVuY2hfc3RhZ2UYASABKA4yFy5nb29nbGUuYXBpLkxhdW5j",
            "aFN0YWdlEjAKDXNhbXBsZV9wZXJpb2QYAiABKAsyGS5nb29nbGUucHJvdG9i",
            "dWYuRHVyYXRpb24SLwoMaW5nZXN0X2RlbGF5GAMgASgLMhkuZ29vZ2xlLnBy",
            "b3RvYnVmLkR1cmF0aW9uIk8KCk1ldHJpY0tpbmQSGwoXTUVUUklDX0tJTkRf",
            "VU5TUEVDSUZJRUQQABIJCgVHQVVHRRABEgkKBURFTFRBEAISDgoKQ1VNVUxB",
            "VElWRRADInEKCVZhbHVlVHlwZRIaChZWQUxVRV9UWVBFX1VOU1BFQ0lGSUVE",
            "EAASCAoEQk9PTBABEgkKBUlOVDY0EAISCgoGRE9VQkxFEAMSCgoGU1RSSU5H",
            "EAQSEAoMRElTVFJJQlVUSU9OEAUSCQoFTU9ORVkQBiJ1CgZNZXRyaWMSDAoE",
            "dHlwZRgDIAEoCRIuCgZsYWJlbHMYAiADKAsyHi5nb29nbGUuYXBpLk1ldHJp",
            "Yy5MYWJlbHNFbnRyeRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBQl8KDmNvbS5nb29nbGUuYXBpQgtNZXRyaWNQcm90",
            "b1ABWjdnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fw",
            "aS9tZXRyaWM7bWV0cmljogIER0FQSWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.LabelReflection.Descriptor, global::Google.Api.LaunchStageReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.MetricDescriptor), global::Google.Api.MetricDescriptor.Parser, new[]{ "Name", "Type", "Labels", "MetricKind", "ValueType", "Unit", "Description", "DisplayName", "Metadata" }, null, new[]{ typeof(global::Google.Api.MetricDescriptor.Types.MetricKind), typeof(global::Google.Api.MetricDescriptor.Types.ValueType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata), global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata.Parser, new[]{ "LaunchStage", "SamplePeriod", "IngestDelay" }, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Metric), global::Google.Api.Metric.Parser, new[]{ "Type", "Labels" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines a metric type and its schema. Once a metric descriptor is created,
  /// deleting or altering it stops data collection and makes the metric type's
  /// existing data unusable.
  /// </summary>
  public sealed partial class MetricDescriptor : pb::IMessage<MetricDescriptor> {
    private static readonly pb::MessageParser<MetricDescriptor> _parser = new pb::MessageParser<MetricDescriptor>(() => new MetricDescriptor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MetricDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.MetricReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricDescriptor(MetricDescriptor other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      labels_ = other.labels_.Clone();
      metricKind_ = other.metricKind_;
      valueType_ = other.valueType_;
      unit_ = other.unit_;
      description_ = other.description_;
      displayName_ = other.displayName_;
      Metadata = other.metadata_ != null ? other.Metadata.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricDescriptor Clone() {
      return new MetricDescriptor(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The resource name of the metric descriptor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 8;
    private string type_ = "";
    /// <summary>
    /// The metric type, including its DNS name prefix. The type is not
    /// URL-encoded.  All user-defined metric types have the DNS name
    /// `custom.googleapis.com` or `external.googleapis.com`.  Metric types should
    /// use a natural hierarchical grouping. For example:
    ///
    ///     "custom.googleapis.com/invoice/paid/amount"
    ///     "external.googleapis.com/prometheus/up"
    ///     "appengine.googleapis.com/http/server/response_latencies"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Api.LabelDescriptor> _repeated_labels_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Api.LabelDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Google.Api.LabelDescriptor> labels_ = new pbc::RepeatedField<global::Google.Api.LabelDescriptor>();
    /// <summary>
    /// The set of labels that can be used to describe a specific
    /// instance of this metric type. For example, the
    /// `appengine.googleapis.com/http/server/response_latencies` metric
    /// type has a label for the HTTP response code, `response_code`, so
    /// you can look at latencies for successful responses or just
    /// for responses that failed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Api.LabelDescriptor> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "metric_kind" field.</summary>
    public const int MetricKindFieldNumber = 3;
    private global::Google.Api.MetricDescriptor.Types.MetricKind metricKind_ = 0;
    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of `metric_kind` and `value_type` might not be supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MetricDescriptor.Types.MetricKind MetricKind {
      get { return metricKind_; }
      set {
        metricKind_ = value;
      }
    }

    /// <summary>Field number for the "value_type" field.</summary>
    public const int ValueTypeFieldNumber = 4;
    private global::Google.Api.MetricDescriptor.Types.ValueType valueType_ = 0;
    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of `metric_kind` and `value_type` might not be supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MetricDescriptor.Types.ValueType ValueType {
      get { return valueType_; }
      set {
        valueType_ = value;
      }
    }

    /// <summary>Field number for the "unit" field.</summary>
    public const int UnitFieldNumber = 5;
    private string unit_ = "";
    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable
    /// if the `value_type` is `INT64`, `DOUBLE`, or `DISTRIBUTION`. The
    /// supported units are a subset of [The Unified Code for Units of
    /// Measure](http://unitsofmeasure.org/ucum.html) standard:
    ///
    /// **Basic units (UNIT)**
    ///
    /// * `bit`   bit
    /// * `By`    byte
    /// * `s`     second
    /// * `min`   minute
    /// * `h`     hour
    /// * `d`     day
    ///
    /// **Prefixes (PREFIX)**
    ///
    /// * `k`     kilo    (10**3)
    /// * `M`     mega    (10**6)
    /// * `G`     giga    (10**9)
    /// * `T`     tera    (10**12)
    /// * `P`     peta    (10**15)
    /// * `E`     exa     (10**18)
    /// * `Z`     zetta   (10**21)
    /// * `Y`     yotta   (10**24)
    /// * `m`     milli   (10**-3)
    /// * `u`     micro   (10**-6)
    /// * `n`     nano    (10**-9)
    /// * `p`     pico    (10**-12)
    /// * `f`     femto   (10**-15)
    /// * `a`     atto    (10**-18)
    /// * `z`     zepto   (10**-21)
    /// * `y`     yocto   (10**-24)
    /// * `Ki`    kibi    (2**10)
    /// * `Mi`    mebi    (2**20)
    /// * `Gi`    gibi    (2**30)
    /// * `Ti`    tebi    (2**40)
    ///
    /// **Grammar**
    ///
    /// The grammar also includes these connectors:
    ///
    /// * `/`    division (as an infix operator, e.g. `1/s`).
    /// * `.`    multiplication (as an infix operator, e.g. `GBy.d`)
    ///
    /// The grammar for a unit is as follows:
    ///
    ///     Expression = Component { "." Component } { "/" Component } ;
    ///
    ///     Component = ( [ PREFIX ] UNIT | "%" ) [ Annotation ]
    ///               | Annotation
    ///               | "1"
    ///               ;
    ///
    ///     Annotation = "{" NAME "}" ;
    ///
    /// Notes:
    ///
    /// * `Annotation` is just a comment if it follows a `UNIT` and is
    ///    equivalent to `1` if it is used alone. For examples,
    ///    `{requests}/s == 1/s`, `By{transmitted}/s == By/s`.
    /// * `NAME` is a sequence of non-blank printable ASCII characters not
    ///    containing '{' or '}'.
    /// * `1` represents dimensionless value 1, such as in `1/s`.
    /// * `%` represents dimensionless value 1/100, and annotates values giving
    ///    a percentage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Unit {
      get { return unit_; }
      set {
        unit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 6;
    private string description_ = "";
    /// <summary>
    /// A detailed description of the metric, which can be used in documentation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 7;
    private string displayName_ = "";
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces.
    /// Use sentence case without an ending period, for example "Request count".
    /// This field is optional but it is recommended to be set for any metrics
    /// associated with user-visible concepts, such as Quota.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 10;
    private global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata metadata_;
    /// <summary>
    /// Optional. Metadata which can be used to guide usage of the metric.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MetricDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MetricDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if(!labels_.Equals(other.labels_)) return false;
      if (MetricKind != other.MetricKind) return false;
      if (ValueType != other.ValueType) return false;
      if (Unit != other.Unit) return false;
      if (Description != other.Description) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= labels_.GetHashCode();
      if (MetricKind != 0) hash ^= MetricKind.GetHashCode();
      if (ValueType != 0) hash ^= ValueType.GetHashCode();
      if (Unit.Length != 0) hash ^= Unit.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
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
      labels_.WriteTo(output, _repeated_labels_codec);
      if (MetricKind != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MetricKind);
      }
      if (ValueType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ValueType);
      }
      if (Unit.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Unit);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Description);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DisplayName);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Type);
      }
      if (metadata_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Metadata);
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
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += labels_.CalculateSize(_repeated_labels_codec);
      if (MetricKind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MetricKind);
      }
      if (ValueType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValueType);
      }
      if (Unit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unit);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MetricDescriptor other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      labels_.Add(other.labels_);
      if (other.MetricKind != 0) {
        MetricKind = other.MetricKind;
      }
      if (other.ValueType != 0) {
        ValueType = other.ValueType;
      }
      if (other.Unit.Length != 0) {
        Unit = other.Unit;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
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
            labels_.AddEntriesFrom(input, _repeated_labels_codec);
            break;
          }
          case 24: {
            metricKind_ = (global::Google.Api.MetricDescriptor.Types.MetricKind) input.ReadEnum();
            break;
          }
          case 32: {
            valueType_ = (global::Google.Api.MetricDescriptor.Types.ValueType) input.ReadEnum();
            break;
          }
          case 42: {
            Unit = input.ReadString();
            break;
          }
          case 50: {
            Description = input.ReadString();
            break;
          }
          case 58: {
            DisplayName = input.ReadString();
            break;
          }
          case 66: {
            Type = input.ReadString();
            break;
          }
          case 82: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Api.MetricDescriptor.Types.MetricDescriptorMetadata();
            }
            input.ReadMessage(metadata_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the MetricDescriptor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The kind of measurement. It describes how the data is reported.
      /// </summary>
      public enum MetricKind {
        /// <summary>
        /// Do not use this default value.
        /// </summary>
        [pbr::OriginalName("METRIC_KIND_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// An instantaneous measurement of a value.
        /// </summary>
        [pbr::OriginalName("GAUGE")] Gauge = 1,
        /// <summary>
        /// The change in a value during a time interval.
        /// </summary>
        [pbr::OriginalName("DELTA")] Delta = 2,
        /// <summary>
        /// A value accumulated over a time interval.  Cumulative
        /// measurements in a time series should have the same start time
        /// and increasing end times, until an event resets the cumulative
        /// value to zero and sets a new start time for the following
        /// points.
        /// </summary>
        [pbr::OriginalName("CUMULATIVE")] Cumulative = 3,
      }

      /// <summary>
      /// The value type of a metric.
      /// </summary>
      public enum ValueType {
        /// <summary>
        /// Do not use this default value.
        /// </summary>
        [pbr::OriginalName("VALUE_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is a boolean.
        /// This value type can be used only if the metric kind is `GAUGE`.
        /// </summary>
        [pbr::OriginalName("BOOL")] Bool = 1,
        /// <summary>
        /// The value is a signed 64-bit integer.
        /// </summary>
        [pbr::OriginalName("INT64")] Int64 = 2,
        /// <summary>
        /// The value is a double precision floating point number.
        /// </summary>
        [pbr::OriginalName("DOUBLE")] Double = 3,
        /// <summary>
        /// The value is a text string.
        /// This value type can be used only if the metric kind is `GAUGE`.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 4,
        /// <summary>
        /// The value is a [`Distribution`][google.api.Distribution].
        /// </summary>
        [pbr::OriginalName("DISTRIBUTION")] Distribution = 5,
        /// <summary>
        /// The value is money.
        /// </summary>
        [pbr::OriginalName("MONEY")] Money = 6,
      }

      /// <summary>
      /// Additional annotations that can be used to guide the usage of a metric.
      /// </summary>
      public sealed partial class MetricDescriptorMetadata : pb::IMessage<MetricDescriptorMetadata> {
        private static readonly pb::MessageParser<MetricDescriptorMetadata> _parser = new pb::MessageParser<MetricDescriptorMetadata>(() => new MetricDescriptorMetadata());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MetricDescriptorMetadata> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Api.MetricDescriptor.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MetricDescriptorMetadata() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MetricDescriptorMetadata(MetricDescriptorMetadata other) : this() {
          launchStage_ = other.launchStage_;
          SamplePeriod = other.samplePeriod_ != null ? other.SamplePeriod.Clone() : null;
          IngestDelay = other.ingestDelay_ != null ? other.IngestDelay.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MetricDescriptorMetadata Clone() {
          return new MetricDescriptorMetadata(this);
        }

        /// <summary>Field number for the "launch_stage" field.</summary>
        public const int LaunchStageFieldNumber = 1;
        private global::Google.Api.LaunchStage launchStage_ = 0;
        /// <summary>
        /// The launch stage of the metric definition.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Api.LaunchStage LaunchStage {
          get { return launchStage_; }
          set {
            launchStage_ = value;
          }
        }

        /// <summary>Field number for the "sample_period" field.</summary>
        public const int SamplePeriodFieldNumber = 2;
        private global::Google.Protobuf.WellKnownTypes.Duration samplePeriod_;
        /// <summary>
        /// The sampling period of metric data points. For metrics which are written
        /// periodically, consecutive data points are stored at this time interval,
        /// excluding data loss due to errors. Metrics with a higher granularity have
        /// a smaller sampling period.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Duration SamplePeriod {
          get { return samplePeriod_; }
          set {
            samplePeriod_ = value;
          }
        }

        /// <summary>Field number for the "ingest_delay" field.</summary>
        public const int IngestDelayFieldNumber = 3;
        private global::Google.Protobuf.WellKnownTypes.Duration ingestDelay_;
        /// <summary>
        /// The delay of data points caused by ingestion. Data points older than this
        /// age are guaranteed to be ingested and available to be read, excluding
        /// data loss due to errors.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Duration IngestDelay {
          get { return ingestDelay_; }
          set {
            ingestDelay_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as MetricDescriptorMetadata);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MetricDescriptorMetadata other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (LaunchStage != other.LaunchStage) return false;
          if (!object.Equals(SamplePeriod, other.SamplePeriod)) return false;
          if (!object.Equals(IngestDelay, other.IngestDelay)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (LaunchStage != 0) hash ^= LaunchStage.GetHashCode();
          if (samplePeriod_ != null) hash ^= SamplePeriod.GetHashCode();
          if (ingestDelay_ != null) hash ^= IngestDelay.GetHashCode();
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
          if (LaunchStage != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) LaunchStage);
          }
          if (samplePeriod_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(SamplePeriod);
          }
          if (ingestDelay_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(IngestDelay);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (LaunchStage != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LaunchStage);
          }
          if (samplePeriod_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(SamplePeriod);
          }
          if (ingestDelay_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(IngestDelay);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MetricDescriptorMetadata other) {
          if (other == null) {
            return;
          }
          if (other.LaunchStage != 0) {
            LaunchStage = other.LaunchStage;
          }
          if (other.samplePeriod_ != null) {
            if (samplePeriod_ == null) {
              samplePeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            SamplePeriod.MergeFrom(other.SamplePeriod);
          }
          if (other.ingestDelay_ != null) {
            if (ingestDelay_ == null) {
              ingestDelay_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            IngestDelay.MergeFrom(other.IngestDelay);
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
                launchStage_ = (global::Google.Api.LaunchStage) input.ReadEnum();
                break;
              }
              case 18: {
                if (samplePeriod_ == null) {
                  samplePeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
                }
                input.ReadMessage(samplePeriod_);
                break;
              }
              case 26: {
                if (ingestDelay_ == null) {
                  ingestDelay_ = new global::Google.Protobuf.WellKnownTypes.Duration();
                }
                input.ReadMessage(ingestDelay_);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// A specific metric, identified by specifying values for all of the
  /// labels of a [`MetricDescriptor`][google.api.MetricDescriptor].
  /// </summary>
  public sealed partial class Metric : pb::IMessage<Metric> {
    private static readonly pb::MessageParser<Metric> _parser = new pb::MessageParser<Metric>(() => new Metric());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Metric> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.MetricReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric(Metric other) : this() {
      type_ = other.type_;
      labels_ = other.labels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric Clone() {
      return new Metric(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    /// <summary>
    /// An existing metric type, see [google.api.MetricDescriptor][google.api.MetricDescriptor].
    /// For example, `custom.googleapis.com/invoice/paid/amount`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The set of label values that uniquely identify this metric. All
    /// labels listed in the `MetricDescriptor` must be assigned values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Metric);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Metric other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!Labels.Equals(other.Labels)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= Labels.GetHashCode();
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
      labels_.WriteTo(output, _map_labels_codec);
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Metric other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      labels_.Add(other.labels_);
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
          case 18: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
