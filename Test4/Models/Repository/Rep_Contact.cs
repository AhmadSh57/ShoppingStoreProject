using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test4.Models.Repository
{
    public class Rep_Contact
    {
        WebStoreDbEntities5 _dbEntities5 = new WebStoreDbEntities5();
        public bool  InsertContact(Tbl_ContactUs Contact)
        {
            _dbEntities5.Tbl_ContactUs.Add(Contact);
            return Convert.ToBoolean(_dbEntities5.SaveChanges());
        }

    }
}