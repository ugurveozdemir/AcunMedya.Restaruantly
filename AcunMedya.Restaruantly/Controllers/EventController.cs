using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class EventController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Events.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateEvent(int id)
        {
            var value = db.Events.Find(id);
            return View(value);
        }
        public ActionResult UpdateEvent(Event eventt)
        {
            var value = db.Events.Find(eventt.EventId);
            value.Title = eventt.Title;
            value.Description = eventt.Description;
            value.ImageUrl = eventt.ImageUrl;
            value.Description2 = eventt.Description2;
            value.Price = eventt.Price;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEvent(Event eventt)
        {
            db.Events.Add(eventt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEvent(int id)
        {
            var value = db.Events.Find(id);
            db.Events.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}