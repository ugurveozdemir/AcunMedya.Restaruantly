using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class ServiceController : Controller
    {
        // GET: WhyUs
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
    }
}