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
    using System.ComponentModel.DataAnnotations;
    using Test4.MetaData;


    [MetadataType(typeof(ContactUs_MetaData))]

    public partial class Tbl_ContactUs
    {
        public long ID { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
    }
}
