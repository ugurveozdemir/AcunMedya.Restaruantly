using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    [Authorize]
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            var values = db.Notifications.Where(x => x.IsRead == "False").ToList();
            return PartialView(values);
        }
   
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter() 
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public ActionResult NotificationToTrue(int id)
        {
            var value = db.Notifications.Find(id);
            value.IsRead = "True";
            db.SaveChanges();
            return RedirectToAction("Index", "Dashboard");
        }
        public PartialViewResult PartialMessages()
        {
            var values = db.Contacts.Where(x => x.IsRead == false).ToList();
            return PartialView(values);
        }
}
    }