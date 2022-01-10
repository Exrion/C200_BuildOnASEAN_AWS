using System.ComponentModel.DataAnnotations;

namespace C200_Web_Application___Identity.Models
{
   public class UserLogin
   {
      [Required(ErrorMessage = "Please enter User ID")]
      public string UserID { get; set; }

      [Required(ErrorMessage = "Please enter Password")]
      public string Password { get; set; }
   }
}

