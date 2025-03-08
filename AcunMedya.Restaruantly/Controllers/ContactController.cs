using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    public class ContactController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            var values = db.Contacts.ToList();
            return View(values);
        }
        public ActionResult Message(int id)
        {
            var values = db.Contacts.Find(id);
            values.IsRead = true;
            db.SaveChanges();
            return View(values);
        }
    }
}