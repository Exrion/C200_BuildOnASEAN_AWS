using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class API_KinesisMedia
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
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

        public class GetMedia
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
            public GetMedia GetMedia { get; set; }
        }

        public class ContentType
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
            public string location { get; set; }
            public string locationName { get; set; }
        }

        public class ContinuationToken
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class FragmentNumberString
        {
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

        public class StreamARN
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StartSelector
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class Members
        {
            public StreamName StreamName { get; set; }
            public StreamARN StreamARN { get; set; }
            public StartSelector StartSelector { get; set; }
            public ContentType ContentType { get; set; }
            public Payload Payload { get; set; }
            public StartSelectorType StartSelectorType { get; set; }
            public AfterFragmentNumber AfterFragmentNumber { get; set; }
            public StartTimestamp StartTimestamp { get; set; }
            public ContinuationToken ContinuationToken { get; set; }
        }

        public class GetMediaInput
        {
            public string type { get; set; }
            public List<string> required { get; set; }
            public Members members { get; set; }
        }

        public class Payload
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public bool streaming { get; set; }
        }

        public class GetMediaOutput
        {
            public string type { get; set; }
            public Members members { get; set; }
            public string payload { get; set; }
        }

        public class ResourceARN
        {
            public string type { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public string pattern { get; set; }
        }

        public class StartSelectorType
        {
            public string shape { get; set; }
            public string documentation { get; set; }
            public string type { get; set; }
            public List<string> @enum { get; set; }
        }

        public class AfterFragmentNumber
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class StartTimestamp
        {
            public string shape { get; set; }
            public string documentation { get; set; }
        }

        public class Timestamp
        {
            public string type { get; set; }
        }

        public class Shapes
        {
            public ContentType ContentType { get; set; }
            public ContinuationToken ContinuationToken { get; set; }
            public FragmentNumberString FragmentNumberString { get; set; }
            public GetMediaInput GetMediaInput { get; set; }
            public GetMediaOutput GetMediaOutput { get; set; }
            public Payload Payload { get; set; }
            public ResourceARN ResourceARN { get; set; }
            public StartSelector StartSelector { get; set; }
            public StartSelectorType StartSelectorType { get; set; }
            public StreamName StreamName { get; set; }
            public Timestamp Timestamp { get; set; }
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
