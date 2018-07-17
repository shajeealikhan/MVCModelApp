using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelApp.Models
{
    public class ResetPassword
    {
        public int LoginId { get; set; }

       
        public string LoginName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = ("Invalid Password"), MinimumLength = 3)]
        [Display(Name = "Reset Password")]
        public string Password { get; set; }
    }
}