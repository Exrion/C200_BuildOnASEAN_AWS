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
        public string location_location_id { get; set; }
        public int organisation_organisation_id { get; set; }
        public string users_Id { get; set; }
        public int notification_notification_id { get; set; }
        public static List<SDA> GetSDAList()
        {
            string sql = @"SELECT * FROM onsite_officers";
            List<SDA> sdaList = DBUtl.GetList<SDA>(sql);
            return sdaList;
        }
    }
}
