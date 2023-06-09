using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test4.Models
{
    public class UserTest_MetaData
    {
        public string Email { get; set; }

    }
    [MetadataType(typeof(UserTest_MetaData))]
    public partial class Tbl_UserTest
    {
    }

}