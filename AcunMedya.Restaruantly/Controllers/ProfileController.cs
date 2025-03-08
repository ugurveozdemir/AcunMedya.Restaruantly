using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
   // [Authorize]
    public class ProfileController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Admins.Find(Session["id"]);
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var value = db.Admins.Find(p.AdminId);
            value.Username = p.Username;
            value.Password = p.Password;
            value.Name = p.Name;
            value.Surname = p.Surname;
            value.ImageUrl  = p.ImageUrl;
            value.Email = p.Email;

            db.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }

    }
}