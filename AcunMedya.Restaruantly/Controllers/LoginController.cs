using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunMedya.Restaruantly.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = db.Admins.FirstOrDefault(x=> x.Username  == p.Username && x.Password == p.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username , true);
                Session["a"] = values.Username;
                Session["id"] = values.AdminId;
                Session["surname"] = values.Surname;
                Session["name"] = values.Name;
                Session["img"] = values.ImageUrl;

                return RedirectToAction("Index","Profile");
            }
            return View();
        }
        
        public ActionResult LogOut()
        {
            // Kullanıcıyı çıkış yaptır
            FormsAuthentication.SignOut();

            // Session verilerini temizle
            Session.Clear();
            Session.Abandon();

            // Kullanıcıyı giriş sayfasına yönlendir
            return RedirectToAction("Index", "Default"); // Giriş sayfasına yönlendir
        }
    }
}