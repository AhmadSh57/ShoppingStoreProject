using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Test4.Models.ViewModels;
namespace Test4.Models.Repository
{
    public class Rep_Products
    {
        WebStoreDbEntities3 DataBase = new WebStoreDbEntities3();

        public List<VM_Products_Pics> ProductByBrandCategory(int ProductBrandCategoryId)
        {
            var QGetProduct = (
                from Product in DataBase.Tbl_Product

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

                select new VM_Products_Pics { ProductId = Product.ProductID, PicName = Picture.PicName, ProductName = Product.ProductTitle, ProductPrice = Product.Price, ProductOff = Product.Product_Off, ProductSubTitle = Category.CategoryTitle, ProductMainTitle = MainCategory.CategoryTitle }
                               );

            return QGetProduct.ToList();
        }

        /*New Products*/
        public List<VM_Products_Pics> NewProducts(int ProductCount)
        {
            var QNewProduct = (
              from Product in DataBase.Tbl_Product

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

              orderby Product.ProductID descending
              select new VM_Products_Pics { ProductId = Product.ProductID, PicName = Picture.PicName, ProductName = Product.ProductTitle, ProductPrice = Product.Price, ProductOff = Product.Product_Off, ProductSubTitle = Category.CategoryTitle, ProductMainTitle = MainCategory.CategoryTitle }

              ).Take(ProductCount);

            return QNewProduct.ToList();


        }

        /*Last Products*/

        public List<VM_Products_Pics> LastProducts(int ProductCount)
        {
            var QLastProduct = (
              from Product in DataBase.Tbl_Product

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

              orderby Product.ProductID
              select new VM_Products_Pics { ProductId = Product.ProductID, PicName = Picture.PicName, ProductName = Product.ProductTitle, ProductPrice = Product.Price, ProductOff = Product.Product_Off, ProductSubTitle = Category.CategoryTitle, ProductMainTitle = MainCategory.CategoryTitle }

              ).Take(ProductCount);

            return QLastProduct.ToList();
        }

        /*Best-selling products*/

        public List<VM_Products_Pics> BestSellingProducts(int DisplayProductCount)
        {
            var QueryBestSelling = (from Product in DataBase.Tbl_Product
                                    join
                                    ProductPic in DataBase.Tbl_ProductImage

                                    on Product.ProductID equals ProductPic.ProductID_FK

                                    join

                                    Pic in DataBase.Tbl_Pictures
                                    on ProductPic.PicID_FK equals Pic.PicId

                                    orderby Product.Sales descending
                                    select new VM_Products_Pics { ProductId = Product.ProductID, ProductName = Product.ProductTitle, PicName = Pic.PicName ,ProductPrice = Product.Price}).Take(DisplayProductCount);
            return QueryBestSelling.ToList();

        }
        /*Product Details*/
        public List<VM_Products_Pics> ProductDetails(int ProductId)
        {
            var QProductDetails = (

                from Product in DataBase.Tbl_Product
                join
                ProductCategory in DataBase.Tbl_Prouducts_Categories
                on Product.ProductID equals ProductCategory.ProductID_FK

                join

                Category in DataBase.Tbl_Category
                on ProductCategory.CatID_FK equals Category.CategoryID

                join

                ProductImage in DataBase.Tbl_ProductImage
                on Product.ProductID equals ProductImage.ProductID_FK

                join

                Picture in DataBase.Tbl_Pictures
                on ProductImage.PicID_FK equals Picture.PicId

                select new VM_Products_Pics { ProductId = Product.ProductID, PicName = Picture.PicName, ProductName = Product.ProductTitle, ProductPrice = Product.Price, ProductOff = Product.Product_Off, ProductSubTitle = Category.CategoryTitle, ProductMainTitle = Category.CategoryTitle }



                                   );


            return QProductDetails.ToList();
        }


    }
}