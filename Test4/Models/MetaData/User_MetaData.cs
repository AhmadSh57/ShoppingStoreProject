
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test4.Models
{
    internal class User_MetaData
    {

        public int UserID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("نام کاربری")]
        [Remote("CheckUserName","Home",ErrorMessage ="این اسم کاربری در سایت وجود دارد")]

        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("رمز عبور ")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0}  خود را وارد کنید")]
        [DisplayName("ایمیل")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "لطفا ادرس ایمیل خود را صحیح وارد نمایید")]
        [Remote("CheckEmail","Home",ErrorMessage ="این {} از قبل وجود دارد")]
        public string Email { get; set; }

        [Required( ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("نام و فامیلی")]
        public string FullName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DisplayName("تاریخ تولد")]

        public string Birthdate { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "  {0}را صحیح وارد نمایید ")]
        [DisplayName("شماره موبایل")]
        [RegularExpression(@"(\+98|0)?9\d{9}", ErrorMessage = "لطفا {0} خود را صحیح وارد نمایید")]
        public string Mobile { get; set; }
        [Required( ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("شماره تلفن")]
        [StringLength(11,MinimumLength =11,ErrorMessage ="حداکثر و حداقل تعداد کاراکتر {0}  11 رقم میباشد")]
        public string TellPhone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("استان")]
        public string Province { get; set; }
        [Required( ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("شهر")]
        public string City { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("آدرس")]
        public string Address { get; set; }
        [Required( ErrorMessage = "لطفا {0} را وارد نمایید")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="لطفا {0} را بصورت 10 رقمی وارد نمایید")]
        [DisplayName(" کد پستی")]
        public string PostalCode { get; set; }
        [Required( ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("تصویر کاربر")]
        public string UserPic { get; set; }
        public string RegisterDate { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "لطفا {0} را وارد نمایید")]
        [DisplayName("جنسیت")]
        public Nullable<bool> Gender { get; set; }
        public string AccessLevelName { get; set; }

    }

 
}