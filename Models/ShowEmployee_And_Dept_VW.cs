//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCModelApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShowEmployee_And_Dept_VW
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Salary { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string Department { get; set; }
    }
}
