using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel_Sitesi.Class;
using Otel_Sitesi.Models;
namespace Otel_Sitesi.Controllers
{
    public class HoteladdController : Controller
    {
        Otel_SitesiEntities1 otel = new Otel_SitesiEntities1();       
        [Authorize] 
        // GET: Hoteladd
        public ActionResult hoteladd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult hoteladd(Tabel_Hotel hotel,FormCollection form)
        {
            hotel.UserName=form["Username"].ToString();
            hotel.Explanation=form["Explanation"].ToString();
            hotel.HotelName=form["HotelName"].ToString();
            hotel.HotelSeller=form["HotelSeller"].ToString();
            hotel.HotelLocation=form["HotelLocation"].ToString();
            hotel.Photo=form["Photo"].ToString();
            otel.Tabel_Hotel.Add(hotel);
            otel.SaveChanges();
            ViewBag.txt = "Kayıt Yapıldı";
            return View();
        }
    }
}