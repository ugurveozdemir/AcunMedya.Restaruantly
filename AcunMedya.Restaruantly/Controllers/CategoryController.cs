using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedya.Restaruantly.Context;

namespace AcunMedya.Restaruantly.Controllers
{
    public class CategoryController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Categorys.ToList();
            return View(values);
        }
    }
}