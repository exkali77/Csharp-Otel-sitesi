using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otel_Sitesi.Class;
using Otel_Sitesi.Models;
using System.Security;
using System.Web.Security;

namespace Otel_Sitesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Otel_SitesiEntities1 otel = new Otel_SitesiEntities1();

        public ActionResult login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult login(TabelUser user)
        {
            var data = otel.TabelUser.FirstOrDefault(x => x.UserName == user.UserName && x.pssword == user.pssword);
            if (data != null)
            {
                FormsAuthentication.SetAuthCookie(data.UserName, false);

                return RedirectToAction("hoteladd", "Hoteladd");
            }
            else
            {
                ViewBag.txt = "Kulanıcı Adı Ve ya Şifre Hatalı";
            return View();

            }

           
        }

    }
}