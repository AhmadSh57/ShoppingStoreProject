using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test4.Models.ViewModels
{
    public class VM_UsertTest
    {
        [Required(ErrorMessage ="لطفا وارد کنید")]
        public string Password { get; set; }
    }
}