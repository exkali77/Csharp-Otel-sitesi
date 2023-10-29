using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel_Sitesi.Models;

namespace Otel_Sitesi.Controllers
{
    public class RegistController : Controller
    {
        // GET: Regist
        Otel_SitesiEntities1 otel = new Otel_SitesiEntities1();
        public ActionResult regist()
        {
            return View();
        }
        [HttpPost]
        public ActionResult regist(TabelUser user)
        {


            if (otel.TabelUser.Any(x => x.UserName == user.UserName))
            {
                ViewBag.txt = "Kulanıcı Adı Var";
                return View();

            }
            else if (user.UserID == 0)
            {
                otel.TabelUser.Add(user);
                otel.SaveChanges();
                return RedirectToAction("login", "Login");


            }
            else
            {
                return View();
            }


        }
    }
}