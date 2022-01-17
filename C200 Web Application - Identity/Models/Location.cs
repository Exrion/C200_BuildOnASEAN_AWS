using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace C200_Web_Application___Identity.Models
{
    public class Location
    {
        [Required]
        [StringLength(5, ErrorMessage = "Maximum 5 characters long")]
        public string location_id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Maximum 150 characters long")]
        public string location_name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Maximum 250 characters long")]
        public string address { get; set; }

        [Required]
        public int level_no { get; set; }

        public int organisation_organisation_id { get; set; }

        [Required]
        public string user_Id { get; set; }
    }
}
