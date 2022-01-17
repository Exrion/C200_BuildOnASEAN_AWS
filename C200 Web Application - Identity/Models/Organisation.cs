using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace C200_Web_Application___Identity.Models
{
    public class Organisation
    {
        public int organisation_id { get; set; }

        [Required] 
        [StringLength(150, ErrorMessage = "Maximum 150 characters long")]
        public string company_name { get; set; }

        [StringLength(250, ErrorMessage = "Maximum 250 characters long")]
        public string description { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email input")]
        public string email_address { get; set; }
    }
}
