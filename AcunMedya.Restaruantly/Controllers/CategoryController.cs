using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;

namespace AcunMedya.Restaruantly.Controllers
{
   // [Authorize]
    public class CategoryController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Categorys.ToList();
            return View(values);
        }
        public ActionResult CategoryList() 
        {
            var values = db.Categorys.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CategoryCreate()
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult CategoryCreate(Category item)
        {
            db.Categorys.Add(item);
            db.SaveChanges();
            return RedirectToAction("CategoryList");

        }
        [HttpGet]
        public ActionResult CategoryUpdate(int id)
        {
            var value = db.Categorys.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category p)
        {
            Category t = db.Categorys.FirstOrDefault(x => x.CategoryId == p.CategoryId);
            t.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult CategoryDelete(int id)
        { 
            var value = db.Categorys.Find(id);
            db.Categorys.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        
        }
    }
}