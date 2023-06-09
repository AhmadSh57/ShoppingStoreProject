using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test4.Models;
using System.Web.Mvc;
using Test4.Models.Repository;
using Test4.Models.ViewModels;
using System.Web.UI.WebControls;
using Test4.App_Start;
using CaptchaMvc;
using CaptchaMvc.HtmlHelpers;
using Test4.Method;
using System.Threading;

namespace Test4.Controllers
{
    public class HomeController : Controller
    {
        WebStoreDbEntities5 DataBase = new WebStoreDbEntities5();



        /*Repositories*/

        Rep_Products _Rep_Products = new Rep_Products();
        Rep_MainNav Rep_MainNav = new Rep_MainNav();
        Rep_Contact Rep_Contact = new Rep_Contact();
        Rep_ProductsFilters Rep_ProductsFilters = new Rep_ProductsFilters();
        Rep_User Rep_User = new Rep_User();


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


        [HttpPost]
        public ActionResult SaveContact(Tbl_ContactUs Table)
        {
            if (ModelState.IsValid)
            {
                if (Rep_Contact.InsertContact(Table))
                {
                    ViewBag.Message = "پیام با موفقیت ارسال شد";
                }
                else
                {
                    ViewBag.Message = "متاسفانه پیام ارسال نشد";
                }
            }
            else
            {
                ViewBag.Message = "لطفا اطلاعات را با دقت وارد نمایید";
            }

            return View("ContactUs");
        }




        public ActionResult NewProducts(int CatId)
        {

            return View(Rep_ProductsFilters.GetNewProducts(CatId));

        }


        public ActionResult GetBestSellingProducts(int CatId)
        {
            return View(Rep_ProductsFilters.GetBestSellingProducts(CatId));
        }


        public ActionResult GetCheapestProducts(int CatId)
        {
            return View(Rep_ProductsFilters.GetCheapestProducts(CatId));
        }
        public ActionResult GetExpensiveProducts(int CatId)
        {
            return View(Rep_ProductsFilters.GetExpensiveProducts(CatId));
        }



        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveUser(VM_RegisterUser VM_User)
        {
            if (this.IsCaptchaValid("Error"))
            {
                if (ModelState.IsValid)

                {
                VM_User.AccessLevelName = "Limit";
                VM_User.RegisterDate = DateTime.Now.ToString();
                    if (Rep_User.InsertUser(VM_User))
                    {
                        ViewBag.Message = "ثبت نام با موفقیت انجام شد";
                    }
                }
                else
                {
                    ViewBag.Message = "لطفا اطلاعات را کامل وارد کنید   ";
                    ViewBag.Style = "Class = 'bg-danger'";
                }
            }
            else
            {
                ViewBag.Message = "لطفا اطلاعات را کامل وارد کنید   ";
                ViewBag.Style = "Class = 'bg-danger'";
            }


            return View("Index");
        }

        public JsonResult CheckMobile(string mobile)
        {
            if (!Rep_User.CheckMobile(mobile))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult CheckUserName(string userName)
        {

            if (!Rep_User.CheckUserName(userName))
            {

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult CheckEmail(string email)
        {
            if (!Rep_User.CheckEmail(email))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult RegisterWith_VM_User()
        {
            return View();
        }

        public static string UserPicName = "";
        [HttpPost]
        public ActionResult InsertUserWith_VM(VM_CompleteUserInfo VM_User, HttpPostedFileBase UserPic)
        {


            //VM_User.RegisterDate = Method.Method.GetShamsiDate(DateTime.Now);

            if (ModelState.IsValid)
            {
            VM_User.AccessLevelName = "Limit";
            VM_User.RegisterDate = DateTime.Now.ToString();
                if (DataBase.Tbl_User.Any(u => u.Mobile == VM_User.Mobile))
                {
                    return RedirectToAction("RegisterWith_VM_User");
                }

                if (UserPic != null && UserPic.ContentLength > 0)
                {
                    if (UserPic.ContentLength / 1024 <= 1000)
                    {

                        if (UserPic.ContentType == "image/jpeg" || UserPic.ContentType == "image/png")
                        {
                            UserPicName = Guid.NewGuid().ToString().Replace('-', ',') + System.IO.Path.GetExtension(UserPic.FileName);
                            string Path = System.IO.Path.Combine(Server.MapPath("~/images/UserPic/" + UserPicName));
                            UserPic.SaveAs(Path);
                            VM_User.UserPic = UserPicName;
                            Response.Write("<script>alert('تصویر کاربری شما با موفقیت ذخیره شد')</script>");

                            //ModelState.AddModelError("UserPic", "تصویر شما با موفقیت ایجاد شد");

                        }
                        else
                        {
                            //ModelState.AddModelError("UserPic", "فرمت عکس شما مجاز نمیباشد");
                            Response.Write("<script>alert('فرمت')</script>");
                            return View("RegisterWith_VM_User");

                        }

                    }
                    else
                    {
                        //ModelState.AddModelError("UserPic", "حداکثر حجم عکس شما 512 است");
                        Response.Write("<script>alert('حجم')</script>");
                        return View("RegisterWith_VM_User");

                    }
                }
                else
                {
                    Response.Write("<script>alert('انتخاب')</script>");
                    return View("RegisterWith_VM_User");
                    //ModelState.AddModelError("UserPic", "لطفا یک عکس انتخاب کنید");
                }

                if (Rep_User.InsertUserWith_VM_CompleteUserInfo(VM_User))
                {
                    ViewBag.Message = "درست";
                    RedirectToAction("RegisterWith_VM_User");
                }
                else
                {
                    ViewBag.Message = "غلط";
                }

            }
            else
            {
                ViewBag.Message = "اطلاعات را صحیح وارد کنید";
            }

            return View("Index");
        }


        public ActionResult GetUsers()
        {
            return View(Rep_User.ShowUsers());
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(VM_UserLogin vM_UserLogin)
        {

            if(ModelState.IsValid)
            {
                bool ResultCheck = Rep_User.CheckUser(vM_UserLogin);
                if (ResultCheck)
                {
                    Session["UserMobile"] = vM_UserLogin.Mobile;
                    Session.Timeout = 3;
                    return RedirectToAction("UserPanel");
                }
                else
                {
                    ViewBag.Message = "همچنین کاربری در سایت موجود نمیباشد";

                }
            }
          
            return View("Login");

        }


       public ActionResult UserPanel()
        {
            if (Session["UserMobile"] != null)
            {
                return View();
            }
            else
            {
                ViewBag.Message = "شما وارد سایت نشدید";
                return View("Login");
            }

        }

        public ActionResult AdminPanel()
        {
            return View();  
        }
    }


}