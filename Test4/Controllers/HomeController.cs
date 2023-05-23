using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test4.Models;
using System.Web.Mvc;

namespace Test4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

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