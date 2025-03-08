using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class FeatureController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Features.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Feature feature)
        {
            var values = db.Features.FirstOrDefault();
            values.Title = feature.Title;
            values.SubTitle = feature.SubTitle;
            values.VideoUrl = feature.VideoUrl;
            values.ImageUrl = feature.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}