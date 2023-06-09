﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test4.Models.ViewModels
{
    public class VM_Products_Pics
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PicName { get; set; }
        public string ProductMainTitle { get; set; }
        public string ProductSubTitle { get; set; }
        public int ProductSubTitleId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal  ProductOff { get; set;}
        public long Sales { get; set; }
        public double Like { get; set; }
       public int Discount { get; set; }
    }
}