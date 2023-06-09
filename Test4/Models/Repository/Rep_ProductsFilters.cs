using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using Test4.Models.ViewModels;

namespace Test4.Models.Repository
{
    public class Rep_ProductsFilters
    {
        WebStoreDbEntities5 db = new WebStoreDbEntities5();

        public List<VM_Products_Pics> GetNewProducts(int CatId) 
        {
            var query = (

               from Product in db.Tbl_Product

               join 

               ProductCat in db.Tbl_Prouducts_Categories 

               on Product.ProductID equals ProductCat.ProductID_FK  

               join 

               SubCat in db.Tbl_Category 

               on ProductCat.CatID_FK equals SubCat.CategoryID
               
               join 

               MainCat in db.Tbl_Category 

               on SubCat.ParentID equals MainCat.CategoryID

               join Image in db.Tbl_ProductImage 

               on Product.ProductID equals Image.ProductID_FK

               join 

               Pic in db.Tbl_Pictures 

               on Image.PicID_FK equals Pic.PicId


               where SubCat.CategoryID == CatId

               orderby Product.ProductID descending

               select new VM_Products_Pics{ProductId  = Product.ProductID,ProductName = Product.ProductTitle,ProductSubTitle = SubCat.CategoryTitle,ProductSubTitleId= SubCat.CategoryID,ProductMainTitle = MainCat.CategoryTitle,PicName = Pic.PicName,ProductOff = Product.Product_Off,ProductPrice = Product.Price}
               
                );

            return query.ToList();
        }

        public List<VM_Products_Pics> GetBestSellingProducts(int CatId)
        {
            var query = (

               from Product in db.Tbl_Product

               join

               ProductCat in db.Tbl_Prouducts_Categories

               on Product.ProductID equals ProductCat.ProductID_FK

               join

               SubCat in db.Tbl_Category

               on ProductCat.CatID_FK equals SubCat.CategoryID

               join

               MainCat in db.Tbl_Category

               on SubCat.ParentID equals MainCat.CategoryID

               join Image in db.Tbl_ProductImage

               on Product.ProductID equals Image.ProductID_FK

               join

               Pic in db.Tbl_Pictures

               on Image.PicID_FK equals Pic.PicId


               where SubCat.CategoryID == CatId

               orderby Product.Sales descending

               select new VM_Products_Pics { ProductId = Product.ProductID, ProductName = Product.ProductTitle, ProductSubTitle = SubCat.CategoryTitle, ProductSubTitleId = SubCat.CategoryID, ProductMainTitle = MainCat.CategoryTitle, PicName = Pic.PicName, ProductOff = Product.Product_Off, ProductPrice = Product.Price ,Sales = Product.Sales}

                );

            return query.ToList();
        }

        public List<VM_Products_Pics> GetCheapestProducts(int CatId)
        {
            var query = (

               from Product in db.Tbl_Product

               join

               ProductCat in db.Tbl_Prouducts_Categories

               on Product.ProductID equals ProductCat.ProductID_FK

               join

               SubCat in db.Tbl_Category

               on ProductCat.CatID_FK equals SubCat.CategoryID

               join

               MainCat in db.Tbl_Category

               on SubCat.ParentID equals MainCat.CategoryID

               join Image in db.Tbl_ProductImage

               on Product.ProductID equals Image.ProductID_FK

               join

               Pic in db.Tbl_Pictures

               on Image.PicID_FK equals Pic.PicId


               where SubCat.CategoryID == CatId

               orderby Product.Price ascending

               select new VM_Products_Pics { ProductId = Product.ProductID, ProductName = Product.ProductTitle, ProductSubTitle = SubCat.CategoryTitle, ProductSubTitleId = SubCat.CategoryID, ProductMainTitle = MainCat.CategoryTitle, PicName = Pic.PicName, ProductOff = Product.Product_Off, ProductPrice = Product.Price, Sales = Product.Sales }

                );

            return query.ToList();
        }

        public List<VM_Products_Pics> GetExpensiveProducts (int CatId)
        {
            var query = (

               from Product in db.Tbl_Product

               join

               ProductCat in db.Tbl_Prouducts_Categories

               on Product.ProductID equals ProductCat.ProductID_FK

               join

               SubCat in db.Tbl_Category

               on ProductCat.CatID_FK equals SubCat.CategoryID

               join

               MainCat in db.Tbl_Category

               on SubCat.ParentID equals MainCat.CategoryID

               join Image in db.Tbl_ProductImage

               on Product.ProductID equals Image.ProductID_FK

               join

               Pic in db.Tbl_Pictures

               on Image.PicID_FK equals Pic.PicId


               where SubCat.CategoryID == CatId

               orderby Product.Price descending

               select new VM_Products_Pics { ProductId = Product.ProductID, ProductName = Product.ProductTitle, ProductSubTitle = SubCat.CategoryTitle, ProductSubTitleId = SubCat.CategoryID, ProductMainTitle = MainCat.CategoryTitle, PicName = Pic.PicName, ProductOff = Product.Product_Off, ProductPrice = Product.Price, Sales = Product.Sales }

                );

            return query.ToList();
        }
    }
}