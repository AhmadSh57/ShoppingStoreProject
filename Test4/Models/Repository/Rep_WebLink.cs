using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test4.Models.Repository
{
    
    public class Rep_WebLink
    {
        WebStoreDbEntities5 db = new WebStoreDbEntities5();
        public List<Tbl_OurWebsites> GetLinks()
        {
            var Query = (
                from a in db.Tbl_OurWebsites 
                orderby a.Sort
                select a
                );

            return Query.ToList();
        }


    }
}