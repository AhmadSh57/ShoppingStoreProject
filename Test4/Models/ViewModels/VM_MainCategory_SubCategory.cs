using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test4.Models.ViewModels
{
    public class VM_MainCategory_SubCategory
    {
        public int MainTitleId { get; set; }
        public string MainTitleName { get; set;}
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryImage { get; set; }

    }
}