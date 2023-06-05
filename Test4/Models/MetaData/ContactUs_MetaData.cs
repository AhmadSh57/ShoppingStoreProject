using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test4.MetaData
{
    internal class ContactUs_MetaData
    {
        public long ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0}  خود را وارد کنید")]
        [MaxLength(150,ErrorMessage ="حداکثر کاراکتر 150 است")]
        [MinLength(1,ErrorMessage ="حداقل کاراکتر 1 است")]
        [DisplayName("نام")]
        public string UserFullName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0}  خود را وارد کنید")]
        [DisplayName("ایمیل")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",ErrorMessage ="لطفا ادرس ایمیل خود را صحیح وارد نمایید")]

        public string UserEmail { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="لطفا {0} خود را وارد کنید")]
        [StringLength(11,MinimumLength =11,ErrorMessage ="  {0}را صحیح وارد نمایید ")]
        [DisplayName("شماره موبایل")]
        [RegularExpression(@"(\+98|0)?9\d{9}",ErrorMessage ="لطفا شماره موبایل خود را صحیح وارد نمایید")]
        public string Mobile { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="لطفا {0} خود را وارد کنید")]
        [StringLength(500,ErrorMessage ="متن شما میتواند حداکثر 500 کاراکتر داشته باشد")]
        [DisplayName("پیام")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }


    }

   
}