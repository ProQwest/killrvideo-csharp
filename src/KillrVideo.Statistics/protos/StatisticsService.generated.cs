// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: statistics/statistics_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KillrVideo.Statistics {

  /// <summary>Holder for reflection information generated from statistics/statistics_service.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class StatisticsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for statistics/statistics_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatisticsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNzdGF0aXN0aWNzL3N0YXRpc3RpY3Nfc2VydmljZS5wcm90bxIVa2lsbHJ2",
            "aWRlby5zdGF0aXN0aWNzGhljb21tb24vY29tbW9uX3R5cGVzLnByb3RvIkkK",
            "HFJlY29yZFBsYXliYWNrU3RhcnRlZFJlcXVlc3QSKQoIdmlkZW9faWQYASAB",
            "KAsyFy5raWxscnZpZGVvLmNvbW1vbi5VdWlkIh8KHVJlY29yZFBsYXliYWNr",
            "U3RhcnRlZFJlc3BvbnNlIkUKF0dldE51bWJlck9mUGxheXNSZXF1ZXN0EioK",
            "CXZpZGVvX2lkcxgBIAMoCzIXLmtpbGxydmlkZW8uY29tbW9uLlV1aWQiSwoY",
            "R2V0TnVtYmVyT2ZQbGF5c1Jlc3BvbnNlEi8KBXN0YXRzGAEgAygLMiAua2ls",
            "bHJ2aWRlby5zdGF0aXN0aWNzLlBsYXlTdGF0cyJFCglQbGF5U3RhdHMSKQoI",
            "dmlkZW9faWQYASABKAsyFy5raWxscnZpZGVvLmNvbW1vbi5VdWlkEg0KBXZp",
            "ZXdzGAIgASgDMo0CChFTdGF0aXN0aWNzU2VydmljZRKCAQoVUmVjb3JkUGxh",
            "eWJhY2tTdGFydGVkEjMua2lsbHJ2aWRlby5zdGF0aXN0aWNzLlJlY29yZFBs",
            "YXliYWNrU3RhcnRlZFJlcXVlc3QaNC5raWxscnZpZGVvLnN0YXRpc3RpY3Mu",
            "UmVjb3JkUGxheWJhY2tTdGFydGVkUmVzcG9uc2UScwoQR2V0TnVtYmVyT2ZQ",
            "bGF5cxIuLmtpbGxydmlkZW8uc3RhdGlzdGljcy5HZXROdW1iZXJPZlBsYXlz",
            "UmVxdWVzdBovLmtpbGxydmlkZW8uc3RhdGlzdGljcy5HZXROdW1iZXJPZlBs",
            "YXlzUmVzcG9uc2VCGKoCFUtpbGxyVmlkZW8uU3RhdGlzdGljc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::KillrVideo.Common.CommonTypesReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Statistics.RecordPlaybackStartedRequest), global::KillrVideo.Statistics.RecordPlaybackStartedRequest.Parser, new[]{ "VideoId" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Statistics.RecordPlaybackStartedResponse), global::KillrVideo.Statistics.RecordPlaybackStartedResponse.Parser, null, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Statistics.GetNumberOfPlaysRequest), global::KillrVideo.Statistics.GetNumberOfPlaysRequest.Parser, new[]{ "VideoIds" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Statistics.GetNumberOfPlaysResponse), global::KillrVideo.Statistics.GetNumberOfPlaysResponse.Parser, new[]{ "Stats" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::KillrVideo.Statistics.PlayStats), global::KillrVideo.Statistics.PlayStats.Parser, new[]{ "VideoId", "Views" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Request for recording that a user started playing back a video
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RecordPlaybackStartedRequest : pb::IMessage<RecordPlaybackStartedRequest> {
    private static readonly pb::MessageParser<RecordPlaybackStartedRequest> _parser = new pb::MessageParser<RecordPlaybackStartedRequest>(() => new RecordPlaybackStartedRequest());
    public static pb::MessageParser<RecordPlaybackStartedRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Statistics.StatisticsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RecordPlaybackStartedRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RecordPlaybackStartedRequest(RecordPlaybackStartedRequest other) : this() {
      VideoId = other.videoId_ != null ? other.VideoId.Clone() : null;
    }

    public RecordPlaybackStartedRequest Clone() {
      return new RecordPlaybackStartedRequest(this);
    }

    /// <summary>Field number for the "video_id" field.</summary>
    public const int VideoIdFieldNumber = 1;
    private global::KillrVideo.Common.Uuid videoId_;
    public global::KillrVideo.Common.Uuid VideoId {
      get { return videoId_; }
      set {
        videoId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as RecordPlaybackStartedRequest);
    }

    public bool Equals(RecordPlaybackStartedRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(VideoId, other.VideoId)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (videoId_ != null) hash ^= VideoId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (videoId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VideoId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (videoId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VideoId);
      }
      return size;
    }

    public void MergeFrom(RecordPlaybackStartedRequest other) {
      if (other == null) {
        return;
      }
      if (other.videoId_ != null) {
        if (videoId_ == null) {
          videoId_ = new global::KillrVideo.Common.Uuid();
        }
        VideoId.MergeFrom(other.VideoId);
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
            if (videoId_ == null) {
              videoId_ = new global::KillrVideo.Common.Uuid();
            }
            input.ReadMessage(videoId_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response when recording that a user started playing back a video
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class RecordPlaybackStartedResponse : pb::IMessage<RecordPlaybackStartedResponse> {
    private static readonly pb::MessageParser<RecordPlaybackStartedResponse> _parser = new pb::MessageParser<RecordPlaybackStartedResponse>(() => new RecordPlaybackStartedResponse());
    public static pb::MessageParser<RecordPlaybackStartedResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Statistics.StatisticsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public RecordPlaybackStartedResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public RecordPlaybackStartedResponse(RecordPlaybackStartedResponse other) : this() {
    }

    public RecordPlaybackStartedResponse Clone() {
      return new RecordPlaybackStartedResponse(this);
    }

    public override bool Equals(object other) {
      return Equals(other as RecordPlaybackStartedResponse);
    }

    public bool Equals(RecordPlaybackStartedResponse other) {
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

    public void MergeFrom(RecordPlaybackStartedResponse other) {
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
  ///  Request for getting the number of times a video or set of videos has been played back
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetNumberOfPlaysRequest : pb::IMessage<GetNumberOfPlaysRequest> {
    private static readonly pb::MessageParser<GetNumberOfPlaysRequest> _parser = new pb::MessageParser<GetNumberOfPlaysRequest>(() => new GetNumberOfPlaysRequest());
    public static pb::MessageParser<GetNumberOfPlaysRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Statistics.StatisticsServiceReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetNumberOfPlaysRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetNumberOfPlaysRequest(GetNumberOfPlaysRequest other) : this() {
      videoIds_ = other.videoIds_.Clone();
    }

    public GetNumberOfPlaysRequest Clone() {
      return new GetNumberOfPlaysRequest(this);
    }

    /// <summary>Field number for the "video_ids" field.</summary>
    public const int VideoIdsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::KillrVideo.Common.Uuid> _repeated_videoIds_codec
        = pb::FieldCodec.ForMessage(10, global::KillrVideo.Common.Uuid.Parser);
    private readonly pbc::RepeatedField<global::KillrVideo.Common.Uuid> videoIds_ = new pbc::RepeatedField<global::KillrVideo.Common.Uuid>();
    public pbc::RepeatedField<global::KillrVideo.Common.Uuid> VideoIds {
      get { return videoIds_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GetNumberOfPlaysRequest);
    }

    public bool Equals(GetNumberOfPlaysRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!videoIds_.Equals(other.videoIds_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= videoIds_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      videoIds_.WriteTo(output, _repeated_videoIds_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += videoIds_.CalculateSize(_repeated_videoIds_codec);
      return size;
    }

    public void MergeFrom(GetNumberOfPlaysRequest other) {
      if (other == null) {
        return;
      }
      videoIds_.Add(other.videoIds_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            videoIds_.AddEntriesFrom(input, _repeated_videoIds_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Response when getting playback stats for a video or set of videos
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetNumberOfPlaysResponse : pb::IMessage<GetNumberOfPlaysResponse> {
    private static readonly pb::MessageParser<GetNumberOfPlaysResponse> _parser = new pb::MessageParser<GetNumberOfPlaysResponse>(() => new GetNumberOfPlaysResponse());
    public static pb::MessageParser<GetNumberOfPlaysResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Statistics.StatisticsServiceReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetNumberOfPlaysResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetNumberOfPlaysResponse(GetNumberOfPlaysResponse other) : this() {
      stats_ = other.stats_.Clone();
    }

    public GetNumberOfPlaysResponse Clone() {
      return new GetNumberOfPlaysResponse(this);
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::KillrVideo.Statistics.PlayStats> _repeated_stats_codec
        = pb::FieldCodec.ForMessage(10, global::KillrVideo.Statistics.PlayStats.Parser);
    private readonly pbc::RepeatedField<global::KillrVideo.Statistics.PlayStats> stats_ = new pbc::RepeatedField<global::KillrVideo.Statistics.PlayStats>();
    public pbc::RepeatedField<global::KillrVideo.Statistics.PlayStats> Stats {
      get { return stats_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GetNumberOfPlaysResponse);
    }

    public bool Equals(GetNumberOfPlaysResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stats_.Equals(other.stats_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= stats_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      stats_.WriteTo(output, _repeated_stats_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += stats_.CalculateSize(_repeated_stats_codec);
      return size;
    }

    public void MergeFrom(GetNumberOfPlaysResponse other) {
      if (other == null) {
        return;
      }
      stats_.Add(other.stats_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            stats_.AddEntriesFrom(input, _repeated_stats_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  The playback stats for a given video id
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayStats : pb::IMessage<PlayStats> {
    private static readonly pb::MessageParser<PlayStats> _parser = new pb::MessageParser<PlayStats>(() => new PlayStats());
    public static pb::MessageParser<PlayStats> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::KillrVideo.Statistics.StatisticsServiceReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayStats(PlayStats other) : this() {
      VideoId = other.videoId_ != null ? other.VideoId.Clone() : null;
      views_ = other.views_;
    }

    public PlayStats Clone() {
      return new PlayStats(this);
    }

    /// <summary>Field number for the "video_id" field.</summary>
    public const int VideoIdFieldNumber = 1;
    private global::KillrVideo.Common.Uuid videoId_;
    public global::KillrVideo.Common.Uuid VideoId {
      get { return videoId_; }
      set {
        videoId_ = value;
      }
    }

    /// <summary>Field number for the "views" field.</summary>
    public const int ViewsFieldNumber = 2;
    private long views_;
    public long Views {
      get { return views_; }
      set {
        views_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayStats);
    }

    public bool Equals(PlayStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(VideoId, other.VideoId)) return false;
      if (Views != other.Views) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (videoId_ != null) hash ^= VideoId.GetHashCode();
      if (Views != 0L) hash ^= Views.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (videoId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VideoId);
      }
      if (Views != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Views);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (videoId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VideoId);
      }
      if (Views != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Views);
      }
      return size;
    }

    public void MergeFrom(PlayStats other) {
      if (other == null) {
        return;
      }
      if (other.videoId_ != null) {
        if (videoId_ == null) {
          videoId_ = new global::KillrVideo.Common.Uuid();
        }
        VideoId.MergeFrom(other.VideoId);
      }
      if (other.Views != 0L) {
        Views = other.Views;
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
            if (videoId_ == null) {
              videoId_ = new global::KillrVideo.Common.Uuid();
            }
            input.ReadMessage(videoId_);
            break;
          }
          case 16: {
            Views = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
