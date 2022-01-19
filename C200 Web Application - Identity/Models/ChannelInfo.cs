using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.KinesisVideo.Model;
using Newtonsoft.Json;

namespace C200_Web_Application___Identity.Models
{
    public class ChannelInfo { 

        public class ChannelNameCondition
        {
            public string ComparisonOperator { get; set; }
            public string ComparisonValue { get; set; }
        }

        public class Root
        {
            public ChannelNameCondition ChannelNameCondition { get; set; }
            public string MaxResults { get; set; }
            public string NextToken { get; set; }
        }

    }
}
