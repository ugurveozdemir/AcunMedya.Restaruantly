using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class AdressController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Adresses.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Adress p)
        {
            var values = db.Adresses.Find(p.AdressId);
            values.Location = p.Location;
            values.OpenHours = p.OpenHours;
            values.Email = p.Email;
            values.Call = p.Call;
            db.SaveChanges();
            return View();
        }
    }
}