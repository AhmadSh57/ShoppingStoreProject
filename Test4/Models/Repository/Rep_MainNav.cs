using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Test4.Models.ViewModels;

namespace Test4.Models.Repository
{
    public class Rep_MainNav
    {
        WebStoreDbEntities3 DataBase = new WebStoreDbEntities3();
        public List<VM_NavLink> Rep_GetMainTitleIconName()
        {
            var Query = (

                from MainTitle in DataBase.Tbl_Category
                join

                MainTitleImage in DataBase.Tbl_MainCategory_Image

                on MainTitle.CategoryID equals MainTitleImage.MainCategoryID_FK
                join

                Pic in DataBase.Tbl_Pictures
                on MainTitleImage.MainCategoryPic_FK equals Pic.PicId

                select new VM_NavLink { NavLinkId = MainTitle.CategoryID,NavIconName = Pic.PicName }
                         );


            return Query.ToList();

        }
    }
}