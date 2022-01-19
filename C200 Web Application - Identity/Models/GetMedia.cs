using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class GetMedia
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class StartSelector
        {
            public string AfterFragmentNumber { get; set; }
            public string ContinuationToken { get; set; }
            public string StartSelectorType { get; set; }
            public string StartTimestamp { get; set; }
        }

        public class Root
        {
            public StartSelector StartSelector { get; set; }
            public string StreamARN { get; set; }
            public string StreamName { get; set; }
        }

    }
}
