using AcunMedya.Restaruantly.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
   // [Authorize]
    public class DashboardController : Controller
    {
        RestaurantlyContext db = new RestaurantlyContext();
        public ActionResult Index()
        {
            ViewBag.productCount = db.Products.Count();
            ViewBag.categoryCount = db.Categorys.Count();
            ViewBag.chefCount = db.Chefs.Count();
            ViewBag.reservationCount = db.Reservations.Count();
            return View();
        }

        public PartialViewResult ReservationPartial()
        {
            var values = db.Reservations.ToList();
            return PartialView(values);
        }
        public ActionResult OKStatus(int id)
        {
            var reservation = db.Reservations.Find(id);
            reservation.ReservationStatus = "Onaylandı";
            db.SaveChanges();
            return RedirectToAction("Index","Reservation");
        }
        public ActionResult NOStatus(int id)
        {
            var reservation = db.Reservations.Find(id);
            reservation.ReservationStatus = "İptal Edildi";
            db.SaveChanges();
            return RedirectToAction("Index","Reservation");
        }
    }
}