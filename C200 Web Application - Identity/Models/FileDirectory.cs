using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace C200_Web_Application___Identity.Models
{
    public class FileDirectory
    {
        //Organisation
        public int Organisation_id { get; set; }

        public string Company_name { get; set; }

        public string Description { get; set; }

        public string Email_address { get; set; }

        //Location
        public string Location_id { get; set; }

        public string Location_name { get; set; }

        public string Address { get; set; }

        public int Level_no { get; set; }

        public int Organisation_organisation_id { get; set; }

        public string User_Id { get; set; }

        //Camera
        public int Camera_id { get; set; }

        public string Serial_no { get; set; }

        public Boolean Status { get; set; }

        public int Location_has_camera_Level_no { get; set; }

        public string Location_location_id { get; set; }
    }
}
