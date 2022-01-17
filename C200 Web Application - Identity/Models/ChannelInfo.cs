using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class ChannelInfo { 
        public class SingleMasterConfiguration
        {
            public DateTime MessageTtlSeconds { get; set; }
        }
        public class ChannelInfoList
        {
            public string ChannelARN { get; set; }
            public string ChannelName { get; set; }
            public string ChannelStatus { get; set; }
            public string ChannelType { get; set; }
            public DateTime CreationTime { get; set; }
            public SingleMasterConfiguration SingleMasterConfiguration { get; set; }
            public string Version { get; set; }

        }
    }
}
