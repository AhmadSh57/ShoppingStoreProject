using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test4.Models;
using System.Web.Mvc;
using Test4.Models.Repository;

namespace Test4.Controllers
{
    public class HomeController : Controller
    {
        WebStoreDbEntities5 DataBase = new WebStoreDbEntities5();

        Rep_Products _Rep_Products = new Rep_Products();
        Rep_MainNav Rep_MainNav = new Rep_MainNav();


        /*Main Page*/
        public ActionResult Index()
        {
            return View();
        }

        /*Product Brand Category*/
        public ActionResult ProductBrandCategory(int ProductBrandCategoryId)
        {
            return View(_Rep_Products.ProductByBrandCategory(ProductBrandCategoryId));
        }

        /*Product Details*/
        public ActionResult ProductDetails(int ProductId)
        {
            return View(_Rep_Products.ProductDetails(ProductId));
        }


        public ActionResult MainCategory(int CategoryId)
        {
            return View(Rep_MainNav.GetSubCategoryForMainTitle(CategoryId));
        }

        public ActionResult SubCategory(int CategoryId)
        {
            return View(Rep_MainNav.GetBrandNameForSubCategory(CategoryId));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }


        public ActionResult ContactUs()
        {

            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult NewProductSlider()
        {
            return PartialView();
        }


    }
}