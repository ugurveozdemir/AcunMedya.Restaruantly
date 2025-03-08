using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class SpecialController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Specials.ToList();
            return View(values);
        }
        public ActionResult UpdateSpecial(int id)
        {
            var values = db.Specials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSpecial(Special s)
        {
            var values = db.Specials.Find(s.SpecialId);
            values.Title = s.Title;
            values.ShortDescription = s.ShortDescription;
            values.LongDescription = s.LongDescription;
            values.ImageUrl = s.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CreateSpecial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSpecial(Special s)
        {
            db.Specials.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSpecial(int id)
        {
            var values = db.Specials.Find(id);
            db.Specials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}