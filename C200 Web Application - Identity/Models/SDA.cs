using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class SDA
    {
        public int officer_id { get; set; }
        public string name { get; set; }
        public int contact_no { get; set; }
        public DateTime dob { get; set; }
        public string location { get; set; }
        public string users_Id { get; set; }
    }

    public class SDAMAIN
    {
        public int officer_count { get; set; }
        public string location { get; set; }
        public string users_Id { get; set; }
    }
}
