//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> JobPostionId_FK { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<System.DateTime> LastEntryDate { get; set; }
        public Nullable<int> EmployeeSituationID_FK { get; set; }
        public Nullable<int> LevelAccessID_FK { get; set; }
    }
}
