using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace MVCModelApp.Models
{
    [MetadataType(typeof(EmpVM))]
    public partial class Employee
    {
         [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        
        public Employee()
        {
            ImagePath = "~/AppFiles/Images/default.png";
        }
    }
    public class EmpVM
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = ("Please enter  Name "))]
        [StringLength(25, ErrorMessage = ("Please enter  Name "), MinimumLength = 3)]
        public string Name { get; set; }
               
        public string Position { get; set; }

        public string Office { get; set; }

        
        [Required(ErrorMessage = ("Please enter  Salary "))]
       // [StringLength(8, ErrorMessage = ("Please enter  Salary "), MinimumLength = 3)]
        public Nullable<int> Salary { get; set; }
       
       
        

        [Required(ErrorMessage = ("Please enter  Department "))]
        [Display(Name = "Department")]
        public Nullable<int> DeptId { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }
        public EmpVM()
        {
            ImagePath = "~/AppFiles/Images/default.png";
        }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        


    }
}