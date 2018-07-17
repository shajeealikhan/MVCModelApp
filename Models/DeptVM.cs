using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCModelApp.Models
{
    [MetadataType(typeof(DeptVM))]
    public partial class Dept
    {
   
        
    }
    public class DeptVM
    {
        [Required(ErrorMessage = ("Please enter Department Name "))]
        [StringLength(25, ErrorMessage = ("Please enter Department Name "), MinimumLength = 3)]
        public string Department { get; set; }

        
        
        
        [Key]
        public int id { get; set; }


    }
}