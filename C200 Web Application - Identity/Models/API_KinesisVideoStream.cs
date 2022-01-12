// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class Metadata
{
    public string apiVersion { get; set; }
    public string endpointPrefix { get; set; }
    public string protocol { get; set; }
    public string serviceAbbreviation { get; set; }
    public string serviceFullName { get; set; }
    public string serviceId { get; set; }
    public string signatureVersion { get; set; }
    public string uid { get; set; }
}

public class Http
{
    public string method { get; set; }
    public string requestUri { get; set; }
}

public class Input
{
    public string shape { get; set; }
}

public class Output
{
    public string shape { get; set; }
}

public class Error
{
    public string shape { get; set; }
}

public class CreateSignalingChannel
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class CreateStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class DeleteSignalingChannel
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class DeleteStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class DescribeSignalingChannel
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class DescribeStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class GetDataEndpoint
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class GetSignalingChannelEndpoint
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class ListSignalingChannels
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class ListStreams
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class ListTagsForResource
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class ListTagsForStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class TagResource
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class TagStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class UntagResource
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class UntagStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class UpdateDataRetention
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class UpdateSignalingChannel
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class UpdateStream
{
    public string name { get; set; }
    public Http http { get; set; }
    public Input input { get; set; }
    public Output output { get; set; }
    public List<Error> errors { get; set; }
    public string documentation { get; set; }
}

public class Operations
{
    public CreateSignalingChannel CreateSignalingChannel { get; set; }
    public CreateStream CreateStream { get; set; }
    public DeleteSignalingChannel DeleteSignalingChannel { get; set; }
    public DeleteStream DeleteStream { get; set; }
    public DescribeSignalingChannel DescribeSignalingChannel { get; set; }
    public DescribeStream DescribeStream { get; set; }
    public GetDataEndpoint GetDataEndpoint { get; set; }
    public GetSignalingChannelEndpoint GetSignalingChannelEndpoint { get; set; }
    public ListSignalingChannels ListSignalingChannels { get; set; }
    public ListStreams ListStreams { get; set; }
    public ListTagsForResource ListTagsForResource { get; set; }
    public ListTagsForStream ListTagsForStream { get; set; }
    public TagResource TagResource { get; set; }
    public TagStream TagStream { get; set; }
    public UntagResource UntagResource { get; set; }
    public UntagStream UntagStream { get; set; }
    public UpdateDataRetention UpdateDataRetention { get; set; }
    public UpdateSignalingChannel UpdateSignalingChannel { get; set; }
    public UpdateStream UpdateStream { get; set; }
}

public class APIName
{
    public string type { get; set; }
    public List<string> @enum { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ChannelName
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class ChannelARN
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ChannelType
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public List<string> @enum { get; set; }
}

public class ChannelStatus
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class CreationTime
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class SingleMasterConfiguration
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Members members { get; set; }
}

public class Version
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class Members
{
    public ChannelName ChannelName { get; set; }
    public ChannelARN ChannelARN { get; set; }
    public ChannelType ChannelType { get; set; }
    public ChannelStatus ChannelStatus { get; set; }
    public CreationTime CreationTime { get; set; }
    public SingleMasterConfiguration SingleMasterConfiguration { get; set; }
    public Version Version { get; set; }
    public ComparisonOperator ComparisonOperator { get; set; }
    public ComparisonValue ComparisonValue { get; set; }
    public Tags Tags { get; set; }
    public DeviceName DeviceName { get; set; }
    public StreamName StreamName { get; set; }
    public MediaType MediaType { get; set; }
    public KmsKeyId KmsKeyId { get; set; }
    public DataRetentionInHours DataRetentionInHours { get; set; }
    public StreamARN StreamARN { get; set; }
    public CurrentVersion CurrentVersion { get; set; }
    public ChannelInfo ChannelInfo { get; set; }
    public StreamInfo StreamInfo { get; set; }
    public APIName APIName { get; set; }
    public DataEndpoint DataEndpoint { get; set; }
    public SingleMasterChannelEndpointConfiguration SingleMasterChannelEndpointConfiguration { get; set; }
    public ResourceEndpointList ResourceEndpointList { get; set; }
    public MaxResults MaxResults { get; set; }
    public NextToken NextToken { get; set; }
    public ChannelNameCondition ChannelNameCondition { get; set; }
    public ChannelInfoList ChannelInfoList { get; set; }
    public StreamNameCondition StreamNameCondition { get; set; }
    public StreamInfoList StreamInfoList { get; set; }
    public ResourceARN ResourceARN { get; set; }
    public Protocol Protocol { get; set; }
    public ResourceEndpoint ResourceEndpoint { get; set; }
    public Protocols Protocols { get; set; }
    public Role Role { get; set; }
    public MessageTtlSeconds MessageTtlSeconds { get; set; }
    public Status Status { get; set; }
    public Key Key { get; set; }
    public Value Value { get; set; }
    public TagKeyList TagKeyList { get; set; }
    public Operation Operation { get; set; }
    public DataRetentionChangeInHours DataRetentionChangeInHours { get; set; }
}

public class ChannelInfo
{
    public string type { get; set; }
    public Members members { get; set; }
    public string documentation { get; set; }
    public string shape { get; set; }
}

public class Member
{
    public string shape { get; set; }
}

public class ChannelInfoList
{
    public string type { get; set; }
    public Member member { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ComparisonOperator
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public List<string> @enum { get; set; }
}

public class ComparisonValue
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ChannelNameCondition
{
    public string type { get; set; }
    public Members members { get; set; }
    public string documentation { get; set; }
    public string shape { get; set; }
}

public class ChannelProtocol
{
    public string type { get; set; }
    public List<string> @enum { get; set; }
}

public class ChannelRole
{
    public string type { get; set; }
    public List<string> @enum { get; set; }
}

public class Tags
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class CreateSignalingChannelInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class CreateSignalingChannelOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DeviceName
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class StreamName
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class MediaType
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class KmsKeyId
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class DataRetentionInHours
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int min { get; set; }
}

public class CreateStreamInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class StreamARN
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class CreateStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DataEndpoint
{
    public string type { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class DataRetentionChangeInHours
{
    public string type { get; set; }
    public int min { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class CurrentVersion
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class DeleteSignalingChannelInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class DeleteSignalingChannelOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DeleteStreamInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class DeleteStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DescribeSignalingChannelInput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DescribeSignalingChannelOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class DescribeStreamInput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class StreamInfo
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Members members { get; set; }
}

public class DescribeStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class GetDataEndpointInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class GetDataEndpointOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class SingleMasterChannelEndpointConfiguration
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Members members { get; set; }
}

public class GetSignalingChannelEndpointInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class ResourceEndpointList
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Member member { get; set; }
}

public class GetSignalingChannelEndpointOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListOfProtocols
{
    public string type { get; set; }
    public Member member { get; set; }
    public int max { get; set; }
    public int min { get; set; }
}

public class MaxResults
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class NextToken
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class ListSignalingChannelsInput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListSignalingChannelsOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class StreamNameCondition
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListStreamsInput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListStreamsInputLimit
{
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
}

public class StreamInfoList
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public Member member { get; set; }
}

public class ListStreamsOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ResourceARN
{
    public string shape { get; set; }
    public string documentation { get; set; }
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class ListTagsForResourceInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class ListTagsForResourceOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListTagsForStreamInput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class ListTagsForStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class MessageTtlSeconds
{
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ResourceEndpoint
{
    public string type { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Protocol
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class ResourceEndpointListItem
{
    public string type { get; set; }
    public Members members { get; set; }
    public string documentation { get; set; }
}

public class Key
{
    public string shape { get; set; }
}

public class Value
{
    public string shape { get; set; }
}

public class ResourceTags
{
    public string type { get; set; }
    public Key key { get; set; }
    public Value value { get; set; }
    public int max { get; set; }
    public int min { get; set; }
}

public class Protocols
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Role
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Status
{
    public string type { get; set; }
    public List<string> @enum { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Key2
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Value2
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class Tag
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
    public string documentation { get; set; }
}

public class TagKey
{
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class TagKeyList
{
    public string type { get; set; }
    public Member member { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class TagList
{
    public string type { get; set; }
    public Member member { get; set; }
    public int max { get; set; }
    public int min { get; set; }
}

public class TagOnCreateList
{
    public string type { get; set; }
    public Member member { get; set; }
    public int max { get; set; }
    public int min { get; set; }
}

public class TagResourceInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class TagResourceOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class TagStreamInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class TagStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class TagValue
{
    public string type { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public string pattern { get; set; }
}

public class Timestamp
{
    public string type { get; set; }
}

public class UntagResourceInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class UntagResourceOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class UntagStreamInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class UntagStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class Operation
{
    public string shape { get; set; }
    public string documentation { get; set; }
}

public class UpdateDataRetentionInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class UpdateDataRetentionOperation
{
    public string type { get; set; }
    public List<string> @enum { get; set; }
}

public class UpdateDataRetentionOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class UpdateSignalingChannelInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class UpdateSignalingChannelOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class UpdateStreamInput
{
    public string type { get; set; }
    public List<string> required { get; set; }
    public Members members { get; set; }
}

public class UpdateStreamOutput
{
    public string type { get; set; }
    public Members members { get; set; }
}

public class Shapes
{
    public APIName APIName { get; set; }
    public ChannelInfo ChannelInfo { get; set; }
    public ChannelInfoList ChannelInfoList { get; set; }
    public ChannelName ChannelName { get; set; }
    public ChannelNameCondition ChannelNameCondition { get; set; }
    public ChannelProtocol ChannelProtocol { get; set; }
    public ChannelRole ChannelRole { get; set; }
    public ChannelType ChannelType { get; set; }
    public ComparisonOperator ComparisonOperator { get; set; }
    public CreateSignalingChannelInput CreateSignalingChannelInput { get; set; }
    public CreateSignalingChannelOutput CreateSignalingChannelOutput { get; set; }
    public CreateStreamInput CreateStreamInput { get; set; }
    public CreateStreamOutput CreateStreamOutput { get; set; }
    public DataEndpoint DataEndpoint { get; set; }
    public DataRetentionChangeInHours DataRetentionChangeInHours { get; set; }
    public DataRetentionInHours DataRetentionInHours { get; set; }
    public DeleteSignalingChannelInput DeleteSignalingChannelInput { get; set; }
    public DeleteSignalingChannelOutput DeleteSignalingChannelOutput { get; set; }
    public DeleteStreamInput DeleteStreamInput { get; set; }
    public DeleteStreamOutput DeleteStreamOutput { get; set; }
    public DescribeSignalingChannelInput DescribeSignalingChannelInput { get; set; }
    public DescribeSignalingChannelOutput DescribeSignalingChannelOutput { get; set; }
    public DescribeStreamInput DescribeStreamInput { get; set; }
    public DescribeStreamOutput DescribeStreamOutput { get; set; }
    public DeviceName DeviceName { get; set; }
    public GetDataEndpointInput GetDataEndpointInput { get; set; }
    public GetDataEndpointOutput GetDataEndpointOutput { get; set; }
    public GetSignalingChannelEndpointInput GetSignalingChannelEndpointInput { get; set; }
    public GetSignalingChannelEndpointOutput GetSignalingChannelEndpointOutput { get; set; }
    public KmsKeyId KmsKeyId { get; set; }
    public ListOfProtocols ListOfProtocols { get; set; }
    public ListSignalingChannelsInput ListSignalingChannelsInput { get; set; }
    public ListSignalingChannelsOutput ListSignalingChannelsOutput { get; set; }
    public ListStreamsInput ListStreamsInput { get; set; }
    public ListStreamsInputLimit ListStreamsInputLimit { get; set; }
    public ListStreamsOutput ListStreamsOutput { get; set; }
    public ListTagsForResourceInput ListTagsForResourceInput { get; set; }
    public ListTagsForResourceOutput ListTagsForResourceOutput { get; set; }
    public ListTagsForStreamInput ListTagsForStreamInput { get; set; }
    public ListTagsForStreamOutput ListTagsForStreamOutput { get; set; }
    public MediaType MediaType { get; set; }
    public MessageTtlSeconds MessageTtlSeconds { get; set; }
    public NextToken NextToken { get; set; }
    public ResourceARN ResourceARN { get; set; }
    public ResourceEndpoint ResourceEndpoint { get; set; }
    public ResourceEndpointList ResourceEndpointList { get; set; }
    public ResourceEndpointListItem ResourceEndpointListItem { get; set; }
    public ResourceTags ResourceTags { get; set; }
    public SingleMasterChannelEndpointConfiguration SingleMasterChannelEndpointConfiguration { get; set; }
    public SingleMasterConfiguration SingleMasterConfiguration { get; set; }
    public Status Status { get; set; }
    public StreamInfo StreamInfo { get; set; }
    public StreamInfoList StreamInfoList { get; set; }
    public StreamName StreamName { get; set; }
    public StreamNameCondition StreamNameCondition { get; set; }
    public Tag Tag { get; set; }
    public TagKey TagKey { get; set; }
    public TagKeyList TagKeyList { get; set; }
    public TagList TagList { get; set; }
    public TagOnCreateList TagOnCreateList { get; set; }
    public TagResourceInput TagResourceInput { get; set; }
    public TagResourceOutput TagResourceOutput { get; set; }
    public TagStreamInput TagStreamInput { get; set; }
    public TagStreamOutput TagStreamOutput { get; set; }
    public TagValue TagValue { get; set; }
    public Timestamp Timestamp { get; set; }
    public UntagResourceInput UntagResourceInput { get; set; }
    public UntagResourceOutput UntagResourceOutput { get; set; }
    public UntagStreamInput UntagStreamInput { get; set; }
    public UntagStreamOutput UntagStreamOutput { get; set; }
    public UpdateDataRetentionInput UpdateDataRetentionInput { get; set; }
    public UpdateDataRetentionOperation UpdateDataRetentionOperation { get; set; }
    public UpdateDataRetentionOutput UpdateDataRetentionOutput { get; set; }
    public UpdateSignalingChannelInput UpdateSignalingChannelInput { get; set; }
    public UpdateSignalingChannelOutput UpdateSignalingChannelOutput { get; set; }
    public UpdateStreamInput UpdateStreamInput { get; set; }
    public UpdateStreamOutput UpdateStreamOutput { get; set; }
    public Version Version { get; set; }
}

public class Root
{
    public string version { get; set; }
    public Metadata metadata { get; set; }
    public Operations operations { get; set; }
    public Shapes shapes { get; set; }
    public string documentation { get; set; }
}