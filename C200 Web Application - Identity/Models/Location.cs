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
        public string Location_id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Maximum 150 characters long")]
        public string Location_name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Maximum 250 characters long")]
        public string Address { get; set; }

        [Required]
        public int Level_no { get; set; }

        public int Organisation_organisation_id { get; set; }

        [Required]
        public string User_Id { get; set; }
    }
}
