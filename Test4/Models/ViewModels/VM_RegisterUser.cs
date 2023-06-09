using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test4.Models.ViewModels
{
    public class VM_RegisterUser
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("رمز عبور ")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="حداقل تعداد {0} 8 کاراکتر است")]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "  {0}را صحیح وارد نمایید ")]
        [DisplayName("شماره موبایل")]
        [RegularExpression(@"(\+98|0)?9\d{9}", ErrorMessage = "لطفا {0} خود را صحیح وارد نمایید")]
        [Remote("CheckMobile","Home",ErrorMessage ="این {0} در سایت وجود دارد")]
        public string Mobile { get; set; }
        public string AccessLevelName { get; set; }
        public string RegisterDate { get; set; }

    }
}