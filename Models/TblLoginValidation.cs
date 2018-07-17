using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelApp.Models
{
  
    public class TblLoginValidation
    {
        [Key]
        public string LoginId { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string LoginName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string LoginType { get; set; } 
    }

    [MetadataType(typeof(TblLoginValidation))]
    public partial class TblLogin
    {
    }


}