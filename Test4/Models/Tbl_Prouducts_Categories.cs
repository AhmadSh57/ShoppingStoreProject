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
    
    public partial class Tbl_Prouducts_Categories
    {
        public int ID { get; set; }
        public Nullable<int> CatID_FK { get; set; }
        public Nullable<int> ProductID_FK { get; set; }
    
        public virtual Tbl_Category Tbl_Category { get; set; }
        public virtual Tbl_Product Tbl_Product { get; set; }
    }
}
