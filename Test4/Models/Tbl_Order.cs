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
    
    public partial class Tbl_Order
    {
        public int OrderID { get; set; }
        public int UserID_FK { get; set; }
        public int Product_FK { get; set; }
        public int OrderCount { get; set; }
        public System.DateTime Date { get; set; }
        public int OrderStatus { get; set; }
        public int PostID_FK { get; set; }
    
        public virtual Tbl_Post Tbl_Post { get; set; }
        public virtual Tbl_Product Tbl_Product { get; set; }
        public virtual Tbl_User Tbl_User { get; set; }
    }
}
