using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class API_Rekognition
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Metadata
        {
            public string apiVersion { get; set; }
            public string endpointPrefix { get; set; }
            public string jsonVersion { get; set; }
            public string protocol { get; set; }
            public string serviceFullName { get; set; }
            public string serviceId { get; set; }
            public string signatureVersion { get; set; }
            public string targetPrefix { get; set; }
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

        public class CompareFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class CreateCollection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class CreateDataset
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class CreateProject
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class CreateProjectVersion
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class CreateStreamProcessor
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteCollection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteDataset
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteProject
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteProjectVersion
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteStreamProcessor
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeCollection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeDataset
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeProjectVersions
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeProjects
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeStreamProcessor
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectCustomLabels
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectLabels
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectModerationLabels
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectProtectiveEquipment
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DetectText
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class DistributeDatasetEntries
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetCelebrityInfo
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetCelebrityRecognition
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetContentModeration
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetFaceDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetFaceSearch
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetLabelDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetPersonTracking
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetSegmentDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class GetTextDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class IndexFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class ListCollections
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class ListDatasetEntries
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class ListDatasetLabels
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class ListFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class ListStreamProcessors
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

        public class RecognizeCelebrities
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class SearchFaces
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class SearchFacesByImage
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class StartCelebrityRecognition
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartContentModeration
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartFaceDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartFaceSearch
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartLabelDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartPersonTracking
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartProjectVersion
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class StartSegmentDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StartStreamProcessor
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class StartTextDetection
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
            public bool idempotent { get; set; }
        }

        public class StopProjectVersion
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class StopStreamProcessor
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

        public class UntagResource
        {
            public string name { get; set; }
            public Http http { get; set; }
            public Input input { get; set; }
            public Output output { get; set; }
            public List<Error> errors { get; set; }
            public string documentation { get; set; }
        }

        public class UpdateDatasetEntries
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
            public CompareFaces CompareFaces { get; set; }
            public CreateCollection CreateCollection { get; set; }
            public CreateDataset CreateDataset { get; set; }
            public CreateProject CreateProject { get; set; }
            public CreateProjectVersion CreateProjectVersion { get; set; }
            public CreateStreamProcessor CreateStreamProcessor { get; set; }
            public DeleteCollection DeleteCollection { get; set; }
            public DeleteDataset DeleteDataset { get; set; }
            public DeleteFaces DeleteFaces { get; set; }
            public DeleteProject DeleteProject { get; set; }
            public DeleteProjectVersion DeleteProjectVersion { get; set; }
            public DeleteStreamProcessor DeleteStreamProcessor { get; set; }
            public DescribeCollection DescribeCollection { get; set; }
            public DescribeDataset DescribeDataset { get; set; }
            public DescribeProjectVersions DescribeProjectVersions { get; set; }
            public DescribeProjects DescribeProjects { get; set; }
            public DescribeStreamProcessor DescribeStreamProcessor { get; set; }
            public DetectCustomLabels DetectCustomLabels { get; set; }
            public DetectFaces DetectFaces { get; set; }
            public DetectLabels DetectLabels { get; set; }
            public DetectModerationLabels DetectModerationLabels { get; set; }
            public DetectProtectiveEquipment DetectProtectiveEquipment { get; set; }
            public DetectText DetectText { get; set; }
            public DistributeDatasetEntries DistributeDatasetEntries { get; set; }
            public GetCelebrityInfo GetCelebrityInfo { get; set; }
            public GetCelebrityRecognition GetCelebrityRecognition { get; set; }
            public GetContentModeration GetContentModeration { get; set; }
            public GetFaceDetection GetFaceDetection { get; set; }
            public GetFaceSearch GetFaceSearch { get; set; }
            public GetLabelDetection GetLabelDetection { get; set; }
            public GetPersonTracking GetPersonTracking { get; set; }
            public GetSegmentDetection GetSegmentDetection { get; set; }
            public GetTextDetection GetTextDetection { get; set; }
            public IndexFaces IndexFaces { get; set; }
            public ListCollections ListCollections { get; set; }
            public ListDatasetEntries ListDatasetEntries { get; set; }
            public ListDatasetLabels ListDatasetLabels { get; set; }
            public ListFaces ListFaces { get; set; }
            public ListStreamProcessors ListStreamProcessors { get; set; }
            public ListTagsForResource ListTagsForResource { get; set; }
            public RecognizeCelebrities RecognizeCelebrities { get; set; }
            public SearchFaces SearchFaces { get; set; }
            public SearchFacesByImage SearchFacesByImage { get; set; }
            public StartCelebrityRecognition StartCelebrityRecognition { get; set; }
            public StartContentModeration StartContentModeration { get; set; }
            public StartFaceDetection StartFaceDetection { get; set; }
            public StartFaceSearch StartFaceSearch { get; set; }
            public StartLabelDetection StartLabelDetection { get; set; }
            public StartPersonTracking StartPersonTracking { get; set; }
            public StartProjectVersion StartProjectVersion { get; set; }
            public StartSegmentDetection StartSegmentDetection { get; set; }
            public StartStreamProcessor StartStreamProcessor { get; set; }
            public StartTextDetection StartTextDetection { get; set; }
            public StopProjectVersion StopProjectVersion { get; set; }
            public StopStreamProcessor StopStreamProcessor { get; set; }
            public TagResource TagResource { get; set; }
            public UntagResource UntagResource { get; set; }
            public UpdateDatasetEntries UpdateDatasetEntries { get; set; }
        }

        public class Low
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class High
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Members
        {
            public Low Low { get; set; }
            public High High { get; set; }
            public GroundTruthManifest GroundTruthManifest { get; set; }
            public Codec Codec { get; set; }
            public DurationMillis DurationMillis { get; set; }
            public SampleRate SampleRate { get; set; }
            public NumberOfChannels NumberOfChannels { get; set; }
            public Value Value { get; set; }
            public Confidence Confidence { get; set; }
            public MaxPixelThreshold MaxPixelThreshold { get; set; }
            public MinCoveragePercentage MinCoveragePercentage { get; set; }
            public Width Width { get; set; }
            public Height Height { get; set; }
            public Left Left { get; set; }
            public Top Top { get; set; }
            public Urls Urls { get; set; }
            public Name Name { get; set; }
            public Id Id { get; set; }
            public Face Face { get; set; }
            public MatchConfidence MatchConfidence { get; set; }
            public KnownGender KnownGender { get; set; }
            public BoundingBox BoundingBox { get; set; }
            public Timestamp Timestamp { get; set; }
            public Celebrity Celebrity { get; set; }
            public Similarity Similarity { get; set; }
            public SourceImage SourceImage { get; set; }
            public TargetImage TargetImage { get; set; }
            public SimilarityThreshold SimilarityThreshold { get; set; }
            public QualityFilter QualityFilter { get; set; }
            public SourceImageFace SourceImageFace { get; set; }
            public FaceMatches FaceMatches { get; set; }
            public UnmatchedFaces UnmatchedFaces { get; set; }
            public SourceImageOrientationCorrection SourceImageOrientationCorrection { get; set; }
            public TargetImageOrientationCorrection TargetImageOrientationCorrection { get; set; }
            public Landmarks Landmarks { get; set; }
            public Pose Pose { get; set; }
            public Quality Quality { get; set; }
            public Emotions Emotions { get; set; }
            public Smile Smile { get; set; }
            public ModerationLabel ModerationLabel { get; set; }
            public CollectionId CollectionId { get; set; }
            public Tags Tags { get; set; }
            public StatusCode StatusCode { get; set; }
            public CollectionArn CollectionArn { get; set; }
            public FaceModelVersion FaceModelVersion { get; set; }
            public DatasetSource DatasetSource { get; set; }
            public DatasetType DatasetType { get; set; }
            public ProjectArn ProjectArn { get; set; }
            public DatasetArn DatasetArn { get; set; }
            public ProjectName ProjectName { get; set; }
            public VersionName VersionName { get; set; }
            public OutputConfig OutputConfig { get; set; }
            public TrainingData TrainingData { get; set; }
            public TestingData TestingData { get; set; }
            public KmsKeyId KmsKeyId { get; set; }
            public ProjectVersionArn ProjectVersionArn { get; set; }
            public Input Input { get; set; }
            public Output Output { get; set; }
            public Settings Settings { get; set; }
            public RoleArn RoleArn { get; set; }
            public StreamProcessorArn StreamProcessorArn { get; set; }
            public Geometry Geometry { get; set; }
            public GroundTruth GroundTruth { get; set; }
            public CreationTimestamp CreationTimestamp { get; set; }
            public LastUpdatedTimestamp LastUpdatedTimestamp { get; set; }
            public Status Status { get; set; }
            public StatusMessage StatusMessage { get; set; }
            public StatusMessageCode StatusMessageCode { get; set; }
            public DatasetStats DatasetStats { get; set; }
            public LabelName LabelName { get; set; }
            public LabelStats LabelStats { get; set; }
            public EntryCount EntryCount { get; set; }
            public BoundingBoxCount BoundingBoxCount { get; set; }
            public LabeledEntries LabeledEntries { get; set; }
            public TotalEntries TotalEntries { get; set; }
            public TotalLabels TotalLabels { get; set; }
            public ErrorEntries ErrorEntries { get; set; }
            public FaceIds FaceIds { get; set; }
            public DeletedFaces DeletedFaces { get; set; }
            public FaceCount FaceCount { get; set; }
            public CollectionArn CollectionARN { get; set; }
            public DatasetDescription DatasetDescription { get; set; }
            public VersionNames VersionNames { get; set; }
            public NextToken NextToken { get; set; }
            public MaxResults MaxResults { get; set; }
            public ProjectVersionDescriptions ProjectVersionDescriptions { get; set; }
            public ProjectNames ProjectNames { get; set; }
            public ProjectDescriptions ProjectDescriptions { get; set; }
            public LastUpdateTimestamp LastUpdateTimestamp { get; set; }
            public Image Image { get; set; }
            public MinConfidence MinConfidence { get; set; }
            public CustomLabels CustomLabels { get; set; }
            public Attributes Attributes { get; set; }
            public FaceDetails FaceDetails { get; set; }
            public OrientationCorrection OrientationCorrection { get; set; }
            public MaxLabels MaxLabels { get; set; }
            public Labels Labels { get; set; }
            public LabelModelVersion LabelModelVersion { get; set; }
            public HumanLoopConfig HumanLoopConfig { get; set; }
            public ModerationLabels ModerationLabels { get; set; }
            public ModerationModelVersion ModerationModelVersion { get; set; }
            public HumanLoopActivationOutput HumanLoopActivationOutput { get; set; }
            public SummarizationAttributes SummarizationAttributes { get; set; }
            public ProtectiveEquipmentModelVersion ProtectiveEquipmentModelVersion { get; set; }
            public Persons Persons { get; set; }
            public Summary Summary { get; set; }
            public WordFilter WordFilter { get; set; }
            public RegionsOfInterest RegionsOfInterest { get; set; }
            public Filters Filters { get; set; }
            public TextDetections TextDetections { get; set; }
            public TextModelVersion TextModelVersion { get; set; }
            public MinBoundingBoxHeight MinBoundingBoxHeight { get; set; }
            public MinBoundingBoxWidth MinBoundingBoxWidth { get; set; }
            public Arn Arn { get; set; }
            public Datasets Datasets { get; set; }
            public Type Type { get; set; }
            public CoversBodyPart CoversBodyPart { get; set; }
            public F1Score F1Score { get; set; }
            public FaceId FaceId { get; set; }
            public ImageId ImageId { get; set; }
            public ExternalImageId ExternalImageId { get; set; }
            public IndexFacesModelVersion IndexFacesModelVersion { get; set; }
            public AgeRange AgeRange { get; set; }
            public Eyeglasses Eyeglasses { get; set; }
            public Sunglasses Sunglasses { get; set; }
            public Gender Gender { get; set; }
            public Beard Beard { get; set; }
            public Mustache Mustache { get; set; }
            public EyesOpen EyesOpen { get; set; }
            public MouthOpen MouthOpen { get; set; }
            public FaceDetail FaceDetail { get; set; }
            public FaceMatchThreshold FaceMatchThreshold { get; set; }
            public Polygon Polygon { get; set; }
            public JobId JobId { get; set; }
            public SortBy SortBy { get; set; }
            public JobStatus JobStatus { get; set; }
            public VideoMetadata VideoMetadata { get; set; }
            public Celebrities Celebrities { get; set; }
            public Faces Faces { get; set; }
            public AudioMetadata AudioMetadata { get; set; }
            public Segments Segments { get; set; }
            public SelectedSegmentTypes SelectedSegmentTypes { get; set; }
            public S3Object S3Object { get; set; }
            public HumanLoopArn HumanLoopArn { get; set; }
            public HumanLoopActivationReasons HumanLoopActivationReasons { get; set; }
            public HumanLoopActivationConditionsEvaluationResults HumanLoopActivationConditionsEvaluationResults { get; set; }
            public HumanLoopName HumanLoopName { get; set; }
            public FlowDefinitionArn FlowDefinitionArn { get; set; }
            public DataAttributes DataAttributes { get; set; }
            public ContentClassifiers ContentClassifiers { get; set; }
            public Bytes Bytes { get; set; }
            public Brightness Brightness { get; set; }
            public Sharpness Sharpness { get; set; }
            public DetectionAttributes DetectionAttributes { get; set; }
            public MaxFaces MaxFaces { get; set; }
            public FaceRecords FaceRecords { get; set; }
            public UnindexedFaces UnindexedFaces { get; set; }
            public Instances Instances { get; set; }
            public Parents Parents { get; set; }
            public Label Label { get; set; }
            public X X { get; set; }
            public Y Y { get; set; }
            public CollectionIds CollectionIds { get; set; }
            public FaceModelVersions FaceModelVersions { get; set; }
            public ContainsLabels ContainsLabels { get; set; }
            public Labeled Labeled { get; set; }
            public SourceRefContains SourceRefContains { get; set; }
            public HasErrors HasErrors { get; set; }
            public DatasetEntries DatasetEntries { get; set; }
            public DatasetLabelDescriptions DatasetLabelDescriptions { get; set; }
            public StreamProcessors StreamProcessors { get; set; }
            public ResourceArn ResourceArn { get; set; }
            public ParentName ParentName { get; set; }
            public SNSTopicArn SNSTopicArn { get; set; }
            public S3Bucket S3Bucket { get; set; }
            public S3KeyPrefix S3KeyPrefix { get; set; }
            public Index Index { get; set; }
            public Person Person { get; set; }
            public Roll Roll { get; set; }
            public Yaw Yaw { get; set; }
            public Pitch Pitch { get; set; }
            public MinInferenceUnits MinInferenceUnits { get; set; }
            public BillableTrainingTimeInSeconds BillableTrainingTimeInSeconds { get; set; }
            public TrainingEndTimestamp TrainingEndTimestamp { get; set; }
            public TrainingDataResult TrainingDataResult { get; set; }
            public TestingDataResult TestingDataResult { get; set; }
            public EvaluationResult EvaluationResult { get; set; }
            public ManifestSummary ManifestSummary { get; set; }
            public EquipmentDetections EquipmentDetections { get; set; }
            public BodyParts BodyParts { get; set; }
            public RequiredEquipmentTypes RequiredEquipmentTypes { get; set; }
            public PersonsWithRequiredEquipment PersonsWithRequiredEquipment { get; set; }
            public PersonsWithoutRequiredEquipment PersonsWithoutRequiredEquipment { get; set; }
            public PersonsIndeterminate PersonsIndeterminate { get; set; }
            public CelebrityFaces CelebrityFaces { get; set; }
            public UnrecognizedFaces UnrecognizedFaces { get; set; }
            public Bucket Bucket { get; set; }
            public Version Version { get; set; }
            public SearchedFaceBoundingBox SearchedFaceBoundingBox { get; set; }
            public SearchedFaceConfidence SearchedFaceConfidence { get; set; }
            public SearchedFaceId SearchedFaceId { get; set; }
            public StartTimestampMillis StartTimestampMillis { get; set; }
            public EndTimestampMillis EndTimestampMillis { get; set; }
            public StartTimecodeSMPTE StartTimecodeSMPTE { get; set; }
            public EndTimecodeSMPTE EndTimecodeSMPTE { get; set; }
            public DurationSMPTE DurationSMPTE { get; set; }
            public TechnicalCueSegment TechnicalCueSegment { get; set; }
            public ShotSegment ShotSegment { get; set; }
            public StartFrameNumber StartFrameNumber { get; set; }
            public EndFrameNumber EndFrameNumber { get; set; }
            public DurationFrames DurationFrames { get; set; }
            public ModelVersion ModelVersion { get; set; }
            public Video Video { get; set; }
            public ClientRequestToken ClientRequestToken { get; set; }
            public NotificationChannel NotificationChannel { get; set; }
            public JobTag JobTag { get; set; }
            public FaceAttributes FaceAttributes { get; set; }
            public TechnicalCueFilter TechnicalCueFilter { get; set; }
            public ShotFilter ShotFilter { get; set; }
            public SegmentTypes SegmentTypes { get; set; }
            public MinSegmentConfidence MinSegmentConfidence { get; set; }
            public BlackFrame BlackFrame { get; set; }
            public KinesisVideoStream KinesisVideoStream { get; set; }
            public KinesisDataStream KinesisDataStream { get; set; }
            public FaceSearch FaceSearch { get; set; }
            public Assets Assets { get; set; }
            public AutoCreate AutoCreate { get; set; }
            public Validation Validation { get; set; }
            public DetectedText DetectedText { get; set; }
            public ParentId ParentId { get; set; }
            public TextDetection TextDetection { get; set; }
            public Reasons Reasons { get; set; }
            public TagKeys TagKeys { get; set; }
            public Changes Changes { get; set; }
            public Format Format { get; set; }
            public FrameRate FrameRate { get; set; }
            public FrameHeight FrameHeight { get; set; }
            public FrameWidth FrameWidth { get; set; }
            public ColorRange ColorRange { get; set; }
        }

        public class AgeRange
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class GroundTruthManifest
        {
            public string shape { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Asset
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Member
        {
            public string shape { get; set; }
        }

        public class Assets
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Attribute
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Attributes
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Codec
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DurationMillis
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SampleRate
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class NumberOfChannels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class AudioMetadata
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class AudioMetadataList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Value
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Confidence
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Beard
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class MaxPixelThreshold
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class MinCoveragePercentage
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class BlackFrame
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class BodyPart
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class BodyParts
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Boolean
        {
            public string type { get; set; }
        }

        public class Width
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Height
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Left
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Top
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class BoundingBox
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class BoundingBoxHeight
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class BoundingBoxWidth
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class Urls
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class Name
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Id
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Face
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MatchConfidence
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class KnownGender
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Celebrity
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class CelebrityDetail
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class CelebrityList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Timestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
        }

        public class CelebrityRecognition
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class CelebrityRecognitionSortBy
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class CelebrityRecognitions
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class ClientRequestToken
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CollectionId
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CollectionIdList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Similarity
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CompareFacesMatch
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class CompareFacesMatchList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class SourceImage
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TargetImage
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SimilarityThreshold
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class QualityFilter
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class CompareFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class SourceImageFace
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FaceMatches
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class UnmatchedFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SourceImageOrientationCorrection
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TargetImageOrientationCorrection
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CompareFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class CompareFacesUnmatchList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Landmarks
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Pose
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Quality
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Emotions
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Smile
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ComparedFace
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ComparedFaceList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class ComparedSourceImageFace
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ContentClassifier
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ContentClassifiers
        {
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ModerationLabel
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ContentModerationDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ContentModerationDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class ContentModerationSortBy
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class CoversBodyPart
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class Tags
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CreateCollectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StatusCode
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CollectionArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FaceModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CreateCollectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DatasetSource
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DatasetType
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ProjectArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class CreateDatasetRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DatasetArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class CreateDatasetResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ProjectName
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class CreateProjectRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class CreateProjectResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class VersionName
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class OutputConfig
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class TrainingData
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class TestingData
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
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

        public class CreateProjectVersionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ProjectVersionArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class CreateProjectVersionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Input59
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Output59
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Settings
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class RoleArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class CreateStreamProcessorRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StreamProcessorArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class CreateStreamProcessorResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Geometry
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class CustomLabel
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class CustomLabels
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GroundTruth
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetChanges
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class CreationTimestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class LastUpdatedTimestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Status
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StatusMessage
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
        }

        public class StatusMessageCode
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetStats
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DatasetDescription
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class DatasetEntries
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetEntry
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class DatasetLabel
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class LabelName
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class LabelStats
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetLabelDescription
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetLabelDescriptions
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EntryCount
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class BoundingBoxCount
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetLabelStats
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetLabels
        {
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class DatasetMetadata
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetMetadataList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class LabeledEntries
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TotalEntries
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TotalLabels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ErrorEntries
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DatasetStatus
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class DatasetStatusMessageCode
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class DateTime
        {
            public string type { get; set; }
        }

        public class Degree
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class DeleteCollectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeleteCollectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DeleteDatasetRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeleteDatasetResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class FaceIds
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeletedFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DeleteFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DeleteProjectRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeleteProjectResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DeleteProjectVersionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeleteProjectVersionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DeleteStreamProcessorRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DeleteStreamProcessorResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DescribeCollectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class FaceCount
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class CollectionARN2
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeCollectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DescribeDatasetRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DescribeDatasetResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class VersionNames
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class NextToken
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class MaxResults
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int min { get; set; }
        }

        public class DescribeProjectVersionsRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ProjectVersionDescriptions
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class DescribeProjectVersionsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ProjectNames
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class DescribeProjectsRequest
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ProjectDescriptions
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class DescribeProjectsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DescribeStreamProcessorRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class LastUpdateTimestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DescribeStreamProcessorResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Image
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MinConfidence
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectCustomLabelsRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DetectCustomLabelsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DetectFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class FaceDetails
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class OrientationCorrection
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class DetectFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MaxLabels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectLabelsRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class Labels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class LabelModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectLabelsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class HumanLoopConfig
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DetectModerationLabelsRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ModerationLabels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class ModerationModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class HumanLoopActivationOutput
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DetectModerationLabelsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class SummarizationAttributes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectProtectiveEquipmentRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ProtectiveEquipmentModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Persons
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Summary
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DetectProtectiveEquipmentResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class WordFilter
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class RegionsOfInterest
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class DetectTextFilters
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Filters
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectTextRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class TextDetections
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TextModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectTextResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MinBoundingBoxHeight
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class MinBoundingBoxWidth
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectionFilter
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Arn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DistributeDataset
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Datasets
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DistributeDatasetEntriesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class DistributeDatasetEntriesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class DistributeDatasetMetadataList
        {
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class Type
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Emotion
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class EmotionName
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class EquipmentDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class EquipmentDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class F1Score
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EvaluationResult
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class ExtendedPaginationToken
        {
            public string type { get; set; }
            public int max { get; set; }
        }

        public class ExternalImageId
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EyeOpen
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Eyeglasses
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class FaceId
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class ImageId
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class IndexFacesModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class FaceAttributes
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Sunglasses
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Gender
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Mustache
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class EyesOpen
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class MouthOpen
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class FaceDetail
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class FaceDetailList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class FaceDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceIdList
        {
            public string type { get; set; }
            public Member member { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class FaceList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceMatch
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class FaceMatchList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceModelVersionList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceRecord
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class FaceRecordList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class FaceMatchThreshold
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FaceSearchSettings
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class FaceSearchSortBy
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Float
        {
            public string type { get; set; }
        }

        public class FlowDefinitionArn
        {
            public string type { get; set; }
            public int max { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GenderType
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Polygon
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class GetCelebrityInfoRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetCelebrityInfoResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class JobId
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class SortBy
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GetCelebrityRecognitionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class JobStatus
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class VideoMetadata
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Celebrities
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GetCelebrityRecognitionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetContentModerationRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetContentModerationResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetFaceDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class Faces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GetFaceDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetFaceSearchRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetFaceSearchResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetLabelDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetLabelDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetPersonTrackingRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetPersonTrackingResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetSegmentDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class Segments
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SelectedSegmentTypes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class GetSegmentDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GetTextDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class GetTextDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class GroundTruthBlob
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class S3Object
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class HasErrors
        {
            public string type { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class HumanLoopActivationConditionsEvaluationResults
        {
            public string type { get; set; }
            public int max { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
            public bool jsonvalue { get; set; }
        }

        public class HumanLoopArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
        }

        public class HumanLoopActivationReasons
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
            public int min { get; set; }
        }

        public class HumanLoopActivationReason
        {
            public string type { get; set; }
        }

        public class HumanLoopName
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class DataAttributes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class HumanLoopDataAttributes
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Bytes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ImageBlob
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class Brightness
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Sharpness
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ImageQuality
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class DetectionAttributes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class MaxFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class IndexFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class FaceRecords
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class UnindexedFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class IndexFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class InferenceUnits
        {
            public string type { get; set; }
            public int min { get; set; }
        }

        public class Instance
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Instances
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class IsLabeled
        {
            public string type { get; set; }
        }

        public class JobTag
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class KinesisDataArn
        {
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class KinesisDataStream
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class KinesisVideoArn
        {
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class KinesisVideoStream
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class KnownGenderType
        {
            public string type { get; set; }
            public string documentation { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Parents
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Label
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class LabelDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class LabelDetectionSortBy
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class LabelDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class X
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Y
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Landmark
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class LandmarkType
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ListCollectionsRequest
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class CollectionIds
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FaceModelVersions
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ListCollectionsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ListDatasetEntriesPageSize
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class ContainsLabels
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Labeled
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SourceRefContains
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ListDatasetEntriesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ListDatasetEntriesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ListDatasetLabelsPageSize
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class ListDatasetLabelsRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ListDatasetLabelsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ListFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ListFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ListStreamProcessorsRequest
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StreamProcessors
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ListStreamProcessorsResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ResourceArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class ListTagsForResourceRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class ListTagsForResourceResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MaxFacesToIndex
        {
            public string type { get; set; }
            public int min { get; set; }
        }

        public class ParentName
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SNSTopicArn
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class NotificationChannel
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class S3Bucket
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class S3KeyPrefix
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public int max { get; set; }
        }

        public class PageSize
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class PaginationToken
        {
            public string type { get; set; }
            public int max { get; set; }
        }

        public class Parent
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Percent
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class Index
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class PersonDetail
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Person
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class PersonDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class PersonDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class PersonIndex
        {
            public string type { get; set; }
        }

        public class PersonMatch
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class PersonMatches
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class PersonTrackingSortBy
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Point
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class Roll
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Yaw
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Pitch
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ProjectDescription
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ProjectStatus
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class MinInferenceUnits
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class BillableTrainingTimeInSeconds
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TrainingEndTimestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TrainingDataResult
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class TestingDataResult
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ManifestSummary
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ProjectVersionDescription
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ProjectVersionStatus
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ProjectVersionsPageSize
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class ProjectsPageSize
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class ProtectiveEquipmentBodyPart
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ProtectiveEquipmentPerson
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ProtectiveEquipmentPersonIds
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class ProtectiveEquipmentPersons
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class RequiredEquipmentTypes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ProtectiveEquipmentSummarizationAttributes
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class PersonsWithRequiredEquipment
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class PersonsWithoutRequiredEquipment
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class PersonsIndeterminate
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ProtectiveEquipmentSummary
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class ProtectiveEquipmentType
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ProtectiveEquipmentTypes
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class QueryString
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class Reason
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Reasons
        {
            public string type { get; set; }
            public Member member { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class RecognizeCelebritiesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class CelebrityFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class UnrecognizedFaces
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class RecognizeCelebritiesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class RegionOfInterest
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class RekognitionUniqueId
        {
            public string type { get; set; }
            public string pattern { get; set; }
        }

        public class Bucket
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Version
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class S3ObjectName
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class S3ObjectVersion
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class SearchFacesByImageRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class SearchedFaceBoundingBox
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SearchedFaceConfidence
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SearchFacesByImageResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class SearchFacesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class SearchedFaceId
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SearchFacesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class SegmentConfidence
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class StartTimestampMillis
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EndTimestampMillis
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StartTimecodeSMPTE
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EndTimecodeSMPTE
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DurationSMPTE
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TechnicalCueSegment
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class ShotSegment
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartFrameNumber
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class EndFrameNumber
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DurationFrames
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SegmentDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class SegmentDetections
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class SegmentType
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class ModelVersion
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SegmentTypeInfo
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class SegmentTypes
        {
            public string type { get; set; }
            public Member member { get; set; }
            public int min { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class SegmentTypesInfo
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Video
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartCelebrityRecognitionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartCelebrityRecognitionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartContentModerationRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartContentModerationResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartFaceDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartFaceDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartFaceSearchRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartFaceSearchResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartLabelDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartLabelDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartPersonTrackingRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartPersonTrackingResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartProjectVersionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartProjectVersionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class TechnicalCueFilter
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ShotFilter
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StartSegmentDetectionFilters
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StartSegmentDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartSegmentDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class MinSegmentConfidence
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StartShotDetectionFilter
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StartStreamProcessorRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartStreamProcessorResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StartTechnicalCueDetectionFilter
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StartTextDetectionFilters
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StartTextDetectionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StartTextDetectionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StopProjectVersionRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StopProjectVersionResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StopStreamProcessorRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class StopStreamProcessorResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class StreamProcessor
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StreamProcessorInput
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StreamProcessorList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class StreamProcessorName
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class StreamProcessorOutput
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class FaceSearch
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StreamProcessorSettings
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class StreamProcessorStatus
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class String
        {
            public string type { get; set; }
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
        }

        public class Key
        {
            public string shape { get; set; }
        }

        public class Value10
        {
            public string shape { get; set; }
        }

        public class TagMap
        {
            public string type { get; set; }
            public Key key { get; set; }
            public Value value { get; set; }
            public int max { get; set; }
            public int min { get; set; }
        }

        public class TagResourceRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class TagResourceResponse
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

        public class TechnicalCueType
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class AutoCreate
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Validation
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class DetectedText
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ParentId
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class TextDetection
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
            public string shape { get; set; }
        }

        public class TextDetectionList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class TextDetectionResult
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class TextDetectionResults
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class TextTypes
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Timecode
        {
            public string type { get; set; }
        }

        public class UInteger
        {
            public string type { get; set; }
            public int min { get; set; }
        }

        public class ULong
        {
            public string type { get; set; }
            public int min { get; set; }
        }

        public class UnindexedFace
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class TagKeys
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class UntagResourceRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class UntagResourceResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Changes
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class UpdateDatasetEntriesRequest
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class UpdateDatasetEntriesResponse
        {
            public string type { get; set; }
            public Members members { get; set; }
        }

        public class Url
        {
            public string type { get; set; }
        }

        public class ValidationData
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string documentation { get; set; }
        }

        public class VideoColorRange
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class VideoJobStatus
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class Format
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FrameRate
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FrameHeight
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FrameWidth
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class ColorRange
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class VideoMetadataList
        {
            public string type { get; set; }
            public Member member { get; set; }
        }

        public class Shapes
        {
            public AgeRange AgeRange { get; set; }
            public Asset Asset { get; set; }
            public Assets Assets { get; set; }
            public Attribute Attribute { get; set; }
            public Attributes Attributes { get; set; }
            public AudioMetadata AudioMetadata { get; set; }
            public AudioMetadataList AudioMetadataList { get; set; }
            public Beard Beard { get; set; }
            public BlackFrame BlackFrame { get; set; }
            public BodyPart BodyPart { get; set; }
            public BodyParts BodyParts { get; set; }
            public Boolean Boolean { get; set; }
            public BoundingBox BoundingBox { get; set; }
            public BoundingBoxHeight BoundingBoxHeight { get; set; }
            public BoundingBoxWidth BoundingBoxWidth { get; set; }
            public Celebrity Celebrity { get; set; }
            public CelebrityDetail CelebrityDetail { get; set; }
            public CelebrityList CelebrityList { get; set; }
            public CelebrityRecognition CelebrityRecognition { get; set; }
            public CelebrityRecognitionSortBy CelebrityRecognitionSortBy { get; set; }
            public CelebrityRecognitions CelebrityRecognitions { get; set; }
            public ClientRequestToken ClientRequestToken { get; set; }
            public CollectionId CollectionId { get; set; }
            public CollectionIdList CollectionIdList { get; set; }
            public CompareFacesMatch CompareFacesMatch { get; set; }
            public CompareFacesMatchList CompareFacesMatchList { get; set; }
            public CompareFacesRequest CompareFacesRequest { get; set; }
            public CompareFacesResponse CompareFacesResponse { get; set; }
            public CompareFacesUnmatchList CompareFacesUnmatchList { get; set; }
            public ComparedFace ComparedFace { get; set; }
            public ComparedFaceList ComparedFaceList { get; set; }
            public ComparedSourceImageFace ComparedSourceImageFace { get; set; }
            public ContentClassifier ContentClassifier { get; set; }
            public ContentClassifiers ContentClassifiers { get; set; }
            public ContentModerationDetection ContentModerationDetection { get; set; }
            public ContentModerationDetections ContentModerationDetections { get; set; }
            public ContentModerationSortBy ContentModerationSortBy { get; set; }
            public CoversBodyPart CoversBodyPart { get; set; }
            public CreateCollectionRequest CreateCollectionRequest { get; set; }
            public CreateCollectionResponse CreateCollectionResponse { get; set; }
            public CreateDatasetRequest CreateDatasetRequest { get; set; }
            public CreateDatasetResponse CreateDatasetResponse { get; set; }
            public CreateProjectRequest CreateProjectRequest { get; set; }
            public CreateProjectResponse CreateProjectResponse { get; set; }
            public CreateProjectVersionRequest CreateProjectVersionRequest { get; set; }
            public CreateProjectVersionResponse CreateProjectVersionResponse { get; set; }
            public CreateStreamProcessorRequest CreateStreamProcessorRequest { get; set; }
            public CreateStreamProcessorResponse CreateStreamProcessorResponse { get; set; }
            public CustomLabel CustomLabel { get; set; }
            public CustomLabels CustomLabels { get; set; }
            public DatasetArn DatasetArn { get; set; }
            public DatasetChanges DatasetChanges { get; set; }
            public DatasetDescription DatasetDescription { get; set; }
            public DatasetEntries DatasetEntries { get; set; }
            public DatasetEntry DatasetEntry { get; set; }
            public DatasetLabel DatasetLabel { get; set; }
            public DatasetLabelDescription DatasetLabelDescription { get; set; }
            public DatasetLabelDescriptions DatasetLabelDescriptions { get; set; }
            public DatasetLabelStats DatasetLabelStats { get; set; }
            public DatasetLabels DatasetLabels { get; set; }
            public DatasetMetadata DatasetMetadata { get; set; }
            public DatasetMetadataList DatasetMetadataList { get; set; }
            public DatasetSource DatasetSource { get; set; }
            public DatasetStats DatasetStats { get; set; }
            public DatasetStatus DatasetStatus { get; set; }
            public DatasetStatusMessageCode DatasetStatusMessageCode { get; set; }
            public DatasetType DatasetType { get; set; }
            public DateTime DateTime { get; set; }
            public Degree Degree { get; set; }
            public DeleteCollectionRequest DeleteCollectionRequest { get; set; }
            public DeleteCollectionResponse DeleteCollectionResponse { get; set; }
            public DeleteDatasetRequest DeleteDatasetRequest { get; set; }
            public DeleteDatasetResponse DeleteDatasetResponse { get; set; }
            public DeleteFacesRequest DeleteFacesRequest { get; set; }
            public DeleteFacesResponse DeleteFacesResponse { get; set; }
            public DeleteProjectRequest DeleteProjectRequest { get; set; }
            public DeleteProjectResponse DeleteProjectResponse { get; set; }
            public DeleteProjectVersionRequest DeleteProjectVersionRequest { get; set; }
            public DeleteProjectVersionResponse DeleteProjectVersionResponse { get; set; }
            public DeleteStreamProcessorRequest DeleteStreamProcessorRequest { get; set; }
            public DeleteStreamProcessorResponse DeleteStreamProcessorResponse { get; set; }
            public DescribeCollectionRequest DescribeCollectionRequest { get; set; }
            public DescribeCollectionResponse DescribeCollectionResponse { get; set; }
            public DescribeDatasetRequest DescribeDatasetRequest { get; set; }
            public DescribeDatasetResponse DescribeDatasetResponse { get; set; }
            public DescribeProjectVersionsRequest DescribeProjectVersionsRequest { get; set; }
            public DescribeProjectVersionsResponse DescribeProjectVersionsResponse { get; set; }
            public DescribeProjectsRequest DescribeProjectsRequest { get; set; }
            public DescribeProjectsResponse DescribeProjectsResponse { get; set; }
            public DescribeStreamProcessorRequest DescribeStreamProcessorRequest { get; set; }
            public DescribeStreamProcessorResponse DescribeStreamProcessorResponse { get; set; }
            public DetectCustomLabelsRequest DetectCustomLabelsRequest { get; set; }
            public DetectCustomLabelsResponse DetectCustomLabelsResponse { get; set; }
            public DetectFacesRequest DetectFacesRequest { get; set; }
            public DetectFacesResponse DetectFacesResponse { get; set; }
            public DetectLabelsRequest DetectLabelsRequest { get; set; }
            public DetectLabelsResponse DetectLabelsResponse { get; set; }
            public DetectModerationLabelsRequest DetectModerationLabelsRequest { get; set; }
            public DetectModerationLabelsResponse DetectModerationLabelsResponse { get; set; }
            public DetectProtectiveEquipmentRequest DetectProtectiveEquipmentRequest { get; set; }
            public DetectProtectiveEquipmentResponse DetectProtectiveEquipmentResponse { get; set; }
            public DetectTextFilters DetectTextFilters { get; set; }
            public DetectTextRequest DetectTextRequest { get; set; }
            public DetectTextResponse DetectTextResponse { get; set; }
            public DetectionFilter DetectionFilter { get; set; }
            public DistributeDataset DistributeDataset { get; set; }
            public DistributeDatasetEntriesRequest DistributeDatasetEntriesRequest { get; set; }
            public DistributeDatasetEntriesResponse DistributeDatasetEntriesResponse { get; set; }
            public DistributeDatasetMetadataList DistributeDatasetMetadataList { get; set; }
            public Emotion Emotion { get; set; }
            public EmotionName EmotionName { get; set; }
            public Emotions Emotions { get; set; }
            public EquipmentDetection EquipmentDetection { get; set; }
            public EquipmentDetections EquipmentDetections { get; set; }
            public EvaluationResult EvaluationResult { get; set; }
            public ExtendedPaginationToken ExtendedPaginationToken { get; set; }
            public ExternalImageId ExternalImageId { get; set; }
            public EyeOpen EyeOpen { get; set; }
            public Eyeglasses Eyeglasses { get; set; }
            public Face Face { get; set; }
            public FaceAttributes FaceAttributes { get; set; }
            public FaceDetail FaceDetail { get; set; }
            public FaceDetailList FaceDetailList { get; set; }
            public FaceDetection FaceDetection { get; set; }
            public FaceDetections FaceDetections { get; set; }
            public FaceId FaceId { get; set; }
            public FaceIdList FaceIdList { get; set; }
            public FaceList FaceList { get; set; }
            public FaceMatch FaceMatch { get; set; }
            public FaceMatchList FaceMatchList { get; set; }
            public FaceModelVersionList FaceModelVersionList { get; set; }
            public FaceRecord FaceRecord { get; set; }
            public FaceRecordList FaceRecordList { get; set; }
            public FaceSearchSettings FaceSearchSettings { get; set; }
            public FaceSearchSortBy FaceSearchSortBy { get; set; }
            public Float Float { get; set; }
            public FlowDefinitionArn FlowDefinitionArn { get; set; }
            public Gender Gender { get; set; }
            public GenderType GenderType { get; set; }
            public Geometry Geometry { get; set; }
            public GetCelebrityInfoRequest GetCelebrityInfoRequest { get; set; }
            public GetCelebrityInfoResponse GetCelebrityInfoResponse { get; set; }
            public GetCelebrityRecognitionRequest GetCelebrityRecognitionRequest { get; set; }
            public GetCelebrityRecognitionResponse GetCelebrityRecognitionResponse { get; set; }
            public GetContentModerationRequest GetContentModerationRequest { get; set; }
            public GetContentModerationResponse GetContentModerationResponse { get; set; }
            public GetFaceDetectionRequest GetFaceDetectionRequest { get; set; }
            public GetFaceDetectionResponse GetFaceDetectionResponse { get; set; }
            public GetFaceSearchRequest GetFaceSearchRequest { get; set; }
            public GetFaceSearchResponse GetFaceSearchResponse { get; set; }
            public GetLabelDetectionRequest GetLabelDetectionRequest { get; set; }
            public GetLabelDetectionResponse GetLabelDetectionResponse { get; set; }
            public GetPersonTrackingRequest GetPersonTrackingRequest { get; set; }
            public GetPersonTrackingResponse GetPersonTrackingResponse { get; set; }
            public GetSegmentDetectionRequest GetSegmentDetectionRequest { get; set; }
            public GetSegmentDetectionResponse GetSegmentDetectionResponse { get; set; }
            public GetTextDetectionRequest GetTextDetectionRequest { get; set; }
            public GetTextDetectionResponse GetTextDetectionResponse { get; set; }
            public GroundTruthBlob GroundTruthBlob { get; set; }
            public GroundTruthManifest GroundTruthManifest { get; set; }
            public HasErrors HasErrors { get; set; }
            public HumanLoopActivationConditionsEvaluationResults HumanLoopActivationConditionsEvaluationResults { get; set; }
            public HumanLoopActivationOutput HumanLoopActivationOutput { get; set; }
            public HumanLoopActivationReason HumanLoopActivationReason { get; set; }
            public HumanLoopActivationReasons HumanLoopActivationReasons { get; set; }
            public HumanLoopArn HumanLoopArn { get; set; }
            public HumanLoopConfig HumanLoopConfig { get; set; }
            public HumanLoopDataAttributes HumanLoopDataAttributes { get; set; }
            public HumanLoopName HumanLoopName { get; set; }
            public Image Image { get; set; }
            public ImageBlob ImageBlob { get; set; }
            public ImageId ImageId { get; set; }
            public ImageQuality ImageQuality { get; set; }
            public IndexFacesModelVersion IndexFacesModelVersion { get; set; }
            public IndexFacesRequest IndexFacesRequest { get; set; }
            public IndexFacesResponse IndexFacesResponse { get; set; }
            public InferenceUnits InferenceUnits { get; set; }
            public Instance Instance { get; set; }
            public Instances Instances { get; set; }
            public IsLabeled IsLabeled { get; set; }
            public JobId JobId { get; set; }
            public JobTag JobTag { get; set; }
            public KinesisDataArn KinesisDataArn { get; set; }
            public KinesisDataStream KinesisDataStream { get; set; }
            public KinesisVideoArn KinesisVideoArn { get; set; }
            public KinesisVideoStream KinesisVideoStream { get; set; }
            public KmsKeyId KmsKeyId { get; set; }
            public KnownGender KnownGender { get; set; }
            public KnownGenderType KnownGenderType { get; set; }
            public Label Label { get; set; }
            public LabelDetection LabelDetection { get; set; }
            public LabelDetectionSortBy LabelDetectionSortBy { get; set; }
            public LabelDetections LabelDetections { get; set; }
            public Labels Labels { get; set; }
            public Landmark Landmark { get; set; }
            public LandmarkType LandmarkType { get; set; }
            public Landmarks Landmarks { get; set; }
            public ListCollectionsRequest ListCollectionsRequest { get; set; }
            public ListCollectionsResponse ListCollectionsResponse { get; set; }
            public ListDatasetEntriesPageSize ListDatasetEntriesPageSize { get; set; }
            public ListDatasetEntriesRequest ListDatasetEntriesRequest { get; set; }
            public ListDatasetEntriesResponse ListDatasetEntriesResponse { get; set; }
            public ListDatasetLabelsPageSize ListDatasetLabelsPageSize { get; set; }
            public ListDatasetLabelsRequest ListDatasetLabelsRequest { get; set; }
            public ListDatasetLabelsResponse ListDatasetLabelsResponse { get; set; }
            public ListFacesRequest ListFacesRequest { get; set; }
            public ListFacesResponse ListFacesResponse { get; set; }
            public ListStreamProcessorsRequest ListStreamProcessorsRequest { get; set; }
            public ListStreamProcessorsResponse ListStreamProcessorsResponse { get; set; }
            public ListTagsForResourceRequest ListTagsForResourceRequest { get; set; }
            public ListTagsForResourceResponse ListTagsForResourceResponse { get; set; }
            public MaxFaces MaxFaces { get; set; }
            public MaxFacesToIndex MaxFacesToIndex { get; set; }
            public MaxPixelThreshold MaxPixelThreshold { get; set; }
            public MaxResults MaxResults { get; set; }
            public MinCoveragePercentage MinCoveragePercentage { get; set; }
            public ModerationLabel ModerationLabel { get; set; }
            public ModerationLabels ModerationLabels { get; set; }
            public MouthOpen MouthOpen { get; set; }
            public Mustache Mustache { get; set; }
            public NotificationChannel NotificationChannel { get; set; }
            public OrientationCorrection OrientationCorrection { get; set; }
            public OutputConfig OutputConfig { get; set; }
            public PageSize PageSize { get; set; }
            public PaginationToken PaginationToken { get; set; }
            public Parent Parent { get; set; }
            public Parents Parents { get; set; }
            public Percent Percent { get; set; }
            public PersonDetail PersonDetail { get; set; }
            public PersonDetection PersonDetection { get; set; }
            public PersonDetections PersonDetections { get; set; }
            public PersonIndex PersonIndex { get; set; }
            public PersonMatch PersonMatch { get; set; }
            public PersonMatches PersonMatches { get; set; }
            public PersonTrackingSortBy PersonTrackingSortBy { get; set; }
            public Point Point { get; set; }
            public Polygon Polygon { get; set; }
            public Pose Pose { get; set; }
            public ProjectArn ProjectArn { get; set; }
            public ProjectDescription ProjectDescription { get; set; }
            public ProjectDescriptions ProjectDescriptions { get; set; }
            public ProjectName ProjectName { get; set; }
            public ProjectNames ProjectNames { get; set; }
            public ProjectStatus ProjectStatus { get; set; }
            public ProjectVersionArn ProjectVersionArn { get; set; }
            public ProjectVersionDescription ProjectVersionDescription { get; set; }
            public ProjectVersionDescriptions ProjectVersionDescriptions { get; set; }
            public ProjectVersionStatus ProjectVersionStatus { get; set; }
            public ProjectVersionsPageSize ProjectVersionsPageSize { get; set; }
            public ProjectsPageSize ProjectsPageSize { get; set; }
            public ProtectiveEquipmentBodyPart ProtectiveEquipmentBodyPart { get; set; }
            public ProtectiveEquipmentPerson ProtectiveEquipmentPerson { get; set; }
            public ProtectiveEquipmentPersonIds ProtectiveEquipmentPersonIds { get; set; }
            public ProtectiveEquipmentPersons ProtectiveEquipmentPersons { get; set; }
            public ProtectiveEquipmentSummarizationAttributes ProtectiveEquipmentSummarizationAttributes { get; set; }
            public ProtectiveEquipmentSummary ProtectiveEquipmentSummary { get; set; }
            public ProtectiveEquipmentType ProtectiveEquipmentType { get; set; }
            public ProtectiveEquipmentTypes ProtectiveEquipmentTypes { get; set; }
            public QualityFilter QualityFilter { get; set; }
            public QueryString QueryString { get; set; }
            public Reason Reason { get; set; }
            public Reasons Reasons { get; set; }
            public RecognizeCelebritiesRequest RecognizeCelebritiesRequest { get; set; }
            public RecognizeCelebritiesResponse RecognizeCelebritiesResponse { get; set; }
            public RegionOfInterest RegionOfInterest { get; set; }
            public RegionsOfInterest RegionsOfInterest { get; set; }
            public RekognitionUniqueId RekognitionUniqueId { get; set; }
            public ResourceArn ResourceArn { get; set; }
            public RoleArn RoleArn { get; set; }
            public S3Bucket S3Bucket { get; set; }
            public S3KeyPrefix S3KeyPrefix { get; set; }
            public S3Object S3Object { get; set; }
            public S3ObjectName S3ObjectName { get; set; }
            public S3ObjectVersion S3ObjectVersion { get; set; }
            public SNSTopicArn SNSTopicArn { get; set; }
            public SearchFacesByImageRequest SearchFacesByImageRequest { get; set; }
            public SearchFacesByImageResponse SearchFacesByImageResponse { get; set; }
            public SearchFacesRequest SearchFacesRequest { get; set; }
            public SearchFacesResponse SearchFacesResponse { get; set; }
            public SegmentConfidence SegmentConfidence { get; set; }
            public SegmentDetection SegmentDetection { get; set; }
            public SegmentDetections SegmentDetections { get; set; }
            public SegmentType SegmentType { get; set; }
            public SegmentTypeInfo SegmentTypeInfo { get; set; }
            public SegmentTypes SegmentTypes { get; set; }
            public SegmentTypesInfo SegmentTypesInfo { get; set; }
            public ShotSegment ShotSegment { get; set; }
            public Smile Smile { get; set; }
            public StartCelebrityRecognitionRequest StartCelebrityRecognitionRequest { get; set; }
            public StartCelebrityRecognitionResponse StartCelebrityRecognitionResponse { get; set; }
            public StartContentModerationRequest StartContentModerationRequest { get; set; }
            public StartContentModerationResponse StartContentModerationResponse { get; set; }
            public StartFaceDetectionRequest StartFaceDetectionRequest { get; set; }
            public StartFaceDetectionResponse StartFaceDetectionResponse { get; set; }
            public StartFaceSearchRequest StartFaceSearchRequest { get; set; }
            public StartFaceSearchResponse StartFaceSearchResponse { get; set; }
            public StartLabelDetectionRequest StartLabelDetectionRequest { get; set; }
            public StartLabelDetectionResponse StartLabelDetectionResponse { get; set; }
            public StartPersonTrackingRequest StartPersonTrackingRequest { get; set; }
            public StartPersonTrackingResponse StartPersonTrackingResponse { get; set; }
            public StartProjectVersionRequest StartProjectVersionRequest { get; set; }
            public StartProjectVersionResponse StartProjectVersionResponse { get; set; }
            public StartSegmentDetectionFilters StartSegmentDetectionFilters { get; set; }
            public StartSegmentDetectionRequest StartSegmentDetectionRequest { get; set; }
            public StartSegmentDetectionResponse StartSegmentDetectionResponse { get; set; }
            public StartShotDetectionFilter StartShotDetectionFilter { get; set; }
            public StartStreamProcessorRequest StartStreamProcessorRequest { get; set; }
            public StartStreamProcessorResponse StartStreamProcessorResponse { get; set; }
            public StartTechnicalCueDetectionFilter StartTechnicalCueDetectionFilter { get; set; }
            public StartTextDetectionFilters StartTextDetectionFilters { get; set; }
            public StartTextDetectionRequest StartTextDetectionRequest { get; set; }
            public StartTextDetectionResponse StartTextDetectionResponse { get; set; }
            public StatusMessage StatusMessage { get; set; }
            public StopProjectVersionRequest StopProjectVersionRequest { get; set; }
            public StopProjectVersionResponse StopProjectVersionResponse { get; set; }
            public StopStreamProcessorRequest StopStreamProcessorRequest { get; set; }
            public StopStreamProcessorResponse StopStreamProcessorResponse { get; set; }
            public StreamProcessor StreamProcessor { get; set; }
            public StreamProcessorArn StreamProcessorArn { get; set; }
            public StreamProcessorInput StreamProcessorInput { get; set; }
            public StreamProcessorList StreamProcessorList { get; set; }
            public StreamProcessorName StreamProcessorName { get; set; }
            public StreamProcessorOutput StreamProcessorOutput { get; set; }
            public StreamProcessorSettings StreamProcessorSettings { get; set; }
            public StreamProcessorStatus StreamProcessorStatus { get; set; }
            public String String { get; set; }
            public Summary Summary { get; set; }
            public Sunglasses Sunglasses { get; set; }
            public TagKey TagKey { get; set; }
            public TagKeyList TagKeyList { get; set; }
            public TagMap TagMap { get; set; }
            public TagResourceRequest TagResourceRequest { get; set; }
            public TagResourceResponse TagResourceResponse { get; set; }
            public TagValue TagValue { get; set; }
            public TechnicalCueSegment TechnicalCueSegment { get; set; }
            public TechnicalCueType TechnicalCueType { get; set; }
            public TestingData TestingData { get; set; }
            public TestingDataResult TestingDataResult { get; set; }
            public TextDetection TextDetection { get; set; }
            public TextDetectionList TextDetectionList { get; set; }
            public TextDetectionResult TextDetectionResult { get; set; }
            public TextDetectionResults TextDetectionResults { get; set; }
            public TextTypes TextTypes { get; set; }
            public Timecode Timecode { get; set; }
            public Timestamp Timestamp { get; set; }
            public TrainingData TrainingData { get; set; }
            public TrainingDataResult TrainingDataResult { get; set; }
            public UInteger UInteger { get; set; }
            public ULong ULong { get; set; }
            public UnindexedFace UnindexedFace { get; set; }
            public UnindexedFaces UnindexedFaces { get; set; }
            public UntagResourceRequest UntagResourceRequest { get; set; }
            public UntagResourceResponse UntagResourceResponse { get; set; }
            public UpdateDatasetEntriesRequest UpdateDatasetEntriesRequest { get; set; }
            public UpdateDatasetEntriesResponse UpdateDatasetEntriesResponse { get; set; }
            public Url Url { get; set; }
            public Urls Urls { get; set; }
            public ValidationData ValidationData { get; set; }
            public VersionName VersionName { get; set; }
            public VersionNames VersionNames { get; set; }
            public Video Video { get; set; }
            public VideoColorRange VideoColorRange { get; set; }
            public VideoJobStatus VideoJobStatus { get; set; }
            public VideoMetadata VideoMetadata { get; set; }
            public VideoMetadataList VideoMetadataList { get; set; }
        }

        public class Root
        {
            public string version { get; set; }
            public Metadata metadata { get; set; }
            public Operations operations { get; set; }
            public Shapes shapes { get; set; }
            public string documentation { get; set; }
        }


    }
}
