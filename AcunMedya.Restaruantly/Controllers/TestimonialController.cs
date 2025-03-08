using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class TestimonialController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial t)
        {
            var values = db.Testimonials.Find(t.TestimonialId);
            values.Name = t.Name;
            values.Description = t.Description;
            values.ImageUrl = t.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonials.Find(id);
            db.Testimonials.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial t)
        {
            db.Testimonials.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}