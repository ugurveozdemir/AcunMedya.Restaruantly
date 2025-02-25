using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        RestaurantlyContext db = new RestaurantlyContext();
   
        public ActionResult ProductList()
        {
            var values = db.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult ProductCreate()
        {
            List<SelectListItem> values = (from x in db.Categorys.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();

        }

        [HttpPost]
        public ActionResult ProductCreate(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
            return RedirectToAction("ProductList");

        }
        [HttpGet]
        public ActionResult ProductUpdate(int id)
        {
            var value = db.Products.Find(id);
            ViewBag.v = db.Categorys
               .Select(c => new SelectListItem
               {
                   Value = c.CategoryId.ToString(),
                   Text = c.CategoryName
               })
               .ToList();
            return View(value);
        }
        [HttpPost]
        public ActionResult ProductUpdate(Product p)
        {
            var t = db.Products.Find(p.ProductId);
            t.Name = p.Name;
            t.Description = p.Description;
            t.Price = p.Price;
            t.ImageUrl = p.ImageUrl;
            t.CategoryId = p.CategoryId;
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public ActionResult ProductDelete(int id)
        {
            var value = db.Products.Find(id);
            db.Products.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProductList");

        }
    }
}