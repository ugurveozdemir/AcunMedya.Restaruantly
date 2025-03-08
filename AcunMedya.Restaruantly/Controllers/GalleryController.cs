using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedya.Restaruantly.Entities;

namespace AcunMedya.Restaruantly.Controllers
{
    public class GalleryController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
         var values = db.Galleries.ToList();
            return View(values);
        }
        public ActionResult UpdateGallery(int id)
        {
            var values = db.Galleries.Find(id);
            return View( values);
        }
        [HttpPost]
        public ActionResult UpdateGallery(Gallery p)
        {
            var values = db.Galleries.Find(p.GalleryId);
            values.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteGallery(int id)
        {
            var values = db.Galleries.Find(id);
            db.Galleries.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CreateGallery(Gallery p)
        {
            db.Galleries.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}