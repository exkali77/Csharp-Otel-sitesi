using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel_Sitesi.Models;
using Otel_Sitesi.Class;
using System.Data.Entity;

namespace Otel_Sitesi.Controllers
{
    public class HomController : Controller
    {
        Otel_SitesiEntities1 otel = new Otel_SitesiEntities1();
       

        // GET: Hom
        public ActionResult HomePage()
        {
            var pro = otel.Tabel_Hotel.ToList();
            return View(pro);
        }
      
        public ActionResult SetCookie()
        {
            HttpCookie myCookie = new HttpCookie("MyCookie");
            myCookie.Value = "This is a cookie.";
            myCookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(myCookie);
            return RedirectToAction("login", "Login");
        }
        public ActionResult GetCookie()
        {
            ViewBag.CookieValue = "";
            if (Request.Cookies["MyCookie"] != null)
            {
                ViewBag.CookieValue = Request.Cookies["MyCookie"].Value;
            }
            return View();
        }
    }
}
