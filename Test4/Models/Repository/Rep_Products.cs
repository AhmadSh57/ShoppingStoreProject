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
        WebStoreDbEntities2 DataBase = new WebStoreDbEntities2();

        public List<VM_Products_Pics> ProductByBrandCategory(int ProductBrandCategoryId)
        {
            var QGetProduct = (from Product in DataBase.Tbl_Product

                               join

                               ProductBrandCategory in DataBase.Tbl_Prouducts_Categories
                               on Product.ProductID equals ProductBrandCategory.ProductID_FK

                               join

                                ProductImage in DataBase.Tbl_ProductImage
                               on Product.ProductID equals ProductImage.ProductID_FK

                               join

                               Picture in DataBase.Tbl_Pictures
                               on ProductImage.PicID_FK equals Picture.PicId
                               where ProductBrandCategory.CatID_FK == ProductBrandCategoryId

                               select new VM_Products_Pics { PicName = Picture.PicName, ProductName = Product.ProductTitle }
                               );
            
            return QGetProduct.ToList();
        }

    }
}