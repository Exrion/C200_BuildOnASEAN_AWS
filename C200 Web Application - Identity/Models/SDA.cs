using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class SDA
    {
        public int Officer_id { get; set; }
        public string Name { get; set; }
        public int Contact_no { get; set; }
        public DateTime Dob { get; set; }
        public string Location { get; set; }
        public string Users_Id { get; set; }
    }

    public class SDAMAIN
    {
        public int Officer_count { get; set; }
        public string Location { get; set; }
        public string Users_Id { get; set; }
    }
}
