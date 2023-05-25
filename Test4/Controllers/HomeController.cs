﻿using System;
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
        WebStoreDbEntities3 DataBase = new WebStoreDbEntities3();

        Rep_Products _Rep_Products = new Rep_Products();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductBrandCategory(int ProductBrandCategoryId)
        {
            return View(_Rep_Products.ProductByBrandCategory(ProductBrandCategoryId));
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