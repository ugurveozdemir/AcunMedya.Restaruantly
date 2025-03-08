using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var value = db.Abouts.FirstOrDefault();
            return View(value);
        }
    }
}