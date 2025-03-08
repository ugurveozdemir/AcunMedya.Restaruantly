using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using AcunMedya.Restaruantly.Context;

namespace AcunMedya.Restaruantly.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly RestaurantlyContext db = new RestaurantlyContext();

        // GET: Statistics
        public ActionResult Index()
        {
            ViewBag.productCount = db.Products.Count();
            ViewBag.categoryCount = db.Categorys.Count();
            ViewBag.chefCount = db.Chefs.Count();
            ViewBag.reservationCount = db.Reservations.Count();
            ViewBag.specialCount = db.Specials.Count();
            ViewBag.testimonialCount = db.Testimonials.Count();
            ViewBag.featureCount = db.Features.Count();
            ViewBag.adressCount = db.Adresses.Count();
            ViewBag.adminCount = db.Admins.Count();
            ViewBag.notificationCount = db.Notifications.Count();
            ViewBag.messageCount = db.Messages.Count();
            ViewBag.galleryCount = db.Galleries.Count();
            ViewBag.eventCount = db.Events.Count();
            ViewBag.serviceCount = db.Services.Count();
            ViewBag.refusedReservationCount = db.Reservations.Count(r => r.ReservationStatus == "İptal Edildi");


            return View();
        }
    }
}
