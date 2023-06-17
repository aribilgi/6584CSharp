using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC10CookieController : Controller
    {
        // GET: MVC10Cookie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CookieOlustur()
        {
            HttpCookie cookie = new HttpCookie("username", "Admin") // adı username olan ve admin verisini taşıyan vir çerez oluşturduk
            {
                Expires = DateTime.Now.AddMinutes(1) // bu çereze 1 dk yaşam süresi verdik sonrasında çerez yok olur.
            };
            HttpContext.Response.Cookies.Add(cookie); // çerezi kullanıcının tarayıcısına ekledik
            return RedirectToAction("Index");
        }
    }
}