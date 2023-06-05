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
        WebStoreDbEntities5 DataBase = new WebStoreDbEntities5();
        public List<VM_MainTitle_Icon> Rep_GetMainTitleIconName()
        {
            var Query = (

                from MainTitle in DataBase.Tbl_Category
                join

                MainTitleImage in DataBase.Tbl_MainCategory_Image

                on MainTitle.CategoryID equals MainTitleImage.MainCategoryID_FK
                join

                Pic in DataBase.Tbl_Pictures
                on MainTitleImage.MainCategoryPic_FK equals Pic.PicId

                select new VM_MainTitle_Icon { NavLinkId = MainTitle.CategoryID, NavIconName = Pic.PicName }
                         );


            return Query.ToList();

        }

        public List<VM_MainCategory_SubCategory> GetSubCategoryForMainTitle(int CategoryId)
        {
            var Query = (
                from Category in DataBase.Tbl_Category

                join

                SubCategory in DataBase.Tbl_Category

                on Category.CategoryID equals SubCategory.ParentID

                join

                 SubCategoryImage in DataBase.Tbl_SubTitle_image

                 on SubCategory.CategoryID equals SubCategoryImage.CategoryId_FK

                join

               Pic in DataBase.Tbl_Pictures

               on SubCategoryImage.CategoryPic_FK equals Pic.PicId

                where Category.CategoryID == CategoryId


                select new VM_MainCategory_SubCategory { SubCategoryId = SubCategory.CategoryID, SubCategoryName = SubCategory.CategoryTitle, MainTitleName = Category.CategoryTitle, MainTitleId = Category.CategoryID, SubCategoryImage = Pic.PicName }

                );

            return Query.ToList();
        }


        public List<VM_SubCategory_ProductsBrands> GetBrandNameForSubCategory(int SubCategoryId)
        {

            var Query = (

                from MainCategory in DataBase.Tbl_Category

                join

                SubCategory in DataBase.Tbl_Category

                on MainCategory.CategoryID equals SubCategory.ParentID

                join

                Brand in DataBase.Tbl_Category

                on SubCategory.CategoryID equals Brand.ParentID


                where SubCategory.CategoryID == SubCategoryId

                select new VM_SubCategory_ProductsBrands { BrandId = Brand.CategoryID, SubCateId = SubCategory.CategoryID, MainTitleId = MainCategory.CategoryID, BrandName = Brand.CategoryTitle, SubCateName = SubCategory.CategoryTitle, MainTitleName = MainCategory.CategoryTitle }

                );

            return Query.ToList();
        }


    }
}