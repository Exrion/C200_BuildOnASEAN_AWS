using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace C200_Web_Application___Identity.Models
{
    public class Camera
    {
        public int Camera_id { get; set; }

        [Required]
        public string Serial_no { get; set; }

        public Boolean Status { get; set; }

        public int Location_has_camera_Level_no { get; set; }

        public string Location_location_id { get; set; }

        public int Organisation_Organisation_id { get; set; }

        public string User_Id {get; set;}

    }
}
