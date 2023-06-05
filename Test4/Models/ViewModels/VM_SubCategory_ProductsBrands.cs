using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test4.Models.ViewModels
{
    public class VM_SubCategory_ProductsBrands
    {
        public int SubCateId { get; set; }
        public string SubCateName { get; set; }
        public int MainTitleId { get; set; }
        public string MainTitleName { get; set; }
        public int BrandId { get; set; }    
        public string BrandName { get; set; }
        

    }
}