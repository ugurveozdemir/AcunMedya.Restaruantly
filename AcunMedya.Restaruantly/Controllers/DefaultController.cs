using AcunMedya.Restaruantly.Context;
using AcunMedya.Restaruantly.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedya.Restaruantly.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        RestaurantlyContext Db = new RestaurantlyContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialTop()
        {
            ViewBag.Call = Db.Adresses.Select(x => x.Call).FirstOrDefault();
            ViewBag.OpenHours = Db.Adresses.Select(x => x.OpenHours).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.SubTitle = Db.Features.Select(x => x.SubTitle).FirstOrDefault();
            ViewBag.Title = Db.Features.Select(x => x.Title).FirstOrDefault();
            ViewBag.VideUrl = Db.Features.Select(x => x.VideoUrl).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.AboutTitle = Db.Abouts.Select(x=> x.Title).FirstOrDefault();
            ViewBag.AboutDescription = Db.Abouts.Select(x=>x.Description).FirstOrDefault();
            ViewBag.AboutFitem = Db.Abouts.Select(x=> x.Fitem).FirstOrDefault();
            ViewBag.AboutSitem = Db.Abouts.Select(x=>x.Sitem).FirstOrDefault();
            ViewBag.AboutTitem = Db.Abouts.Select(x=>x.Titem).FirstOrDefault();
            ViewBag.AboutImage = Db.Abouts.Select(x=>x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = Db.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialMenu()
        {
            var values = Db.Products.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        public ActionResult ContactAdd(Contact model)
        {
            model.SendDate = DateTime.Now;
            model.IsRead = false;
            Db.Contacts.Add(model);
            Db.SaveChanges();
            ViewBag.Message = "Mesajınız alınmıştır. Teşekkür ederiz.";
            return View("Index");

        }

        public PartialViewResult PartialSpecial()
        {
            var values = Db.Specials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }
        public ActionResult BookATable(Reservation model)
        {
            model.ReservationStatus = "Onaylandı";
            Db.Reservations.Add(model);
            Db.SaveChanges();
            ViewBag.ReservationMessage = "Rezervasyonunuz onaylandı, teşekkür ederiz.";
            return View("Index");
        } 

        public PartialViewResult PartialTestimonial()
        {
            var values = Db.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialChef()
        {
            var values = Db.Chefs.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialAdress()
        {
            ViewBag.AdressLocation = Db.Adresses.Select(x=>x.Location).FirstOrDefault();
            ViewBag.AdressOpenHours = Db.Adresses.Select(x => x.OpenHours).FirstOrDefault();
            ViewBag.AdressEmail = Db.Adresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.AdressCall = Db.Adresses.Select(x => x.Call).FirstOrDefault();
 
            return PartialView();
        }
    }
}