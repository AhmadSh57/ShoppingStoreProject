using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test4.Models.ViewModels;
namespace Test4.Models.Repository
{
    public class Rep_Products
    {
        WebStoreDbEntities3 DataBase = new WebStoreDbEntities3();

        public List<VM_Products_Pics> ProductByBrandCategory(int ProductBrandCategoryId)
        {
            var QGetProduct = (from Product in DataBase.Tbl_Product

                               join

                               ProductBrandCategory in DataBase.Tbl_Prouducts_Categories
                               on Product.ProductID equals ProductBrandCategory.ProductID_FK

                               join

                               Category in DataBase.Tbl_Category
                               on ProductBrandCategory.CatID_FK equals Category.CategoryID

                               join

                               MainCategory in DataBase.Tbl_Category
                               on Category.ParentID equals MainCategory.CategoryID

                               join

                                ProductImage in DataBase.Tbl_ProductImage
                               on Product.ProductID equals ProductImage.ProductID_FK

                               join

                               Picture in DataBase.Tbl_Pictures
                               on ProductImage.PicID_FK equals Picture.PicId



                               where ProductBrandCategory.CatID_FK == ProductBrandCategoryId

                               select new VM_Products_Pics {ProductId = Product.ProductID, PicName = Picture.PicName, ProductName = Product.ProductTitle, ProductPrice = Product.Price,ProductOff = Product.Product_Off, ProductSubTitle = Category.CategoryTitle, ProductMainTitle = MainCategory.CategoryTitle }
                               ); 
            
            return QGetProduct.ToList();
        }

    }
}