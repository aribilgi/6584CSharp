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
            TempData["mesaj"] = "<div class='alert alert-success'>Cookie Oluşturuldu!</div>";
            return RedirectToAction("Index");
        }
        public ActionResult CookieOku()
        {
            if (HttpContext.Request.Cookies["username"] != null)
            {
                TempData["kullaniciadi"] = HttpContext.Request.Cookies["username"].Value; // uygulamanın oluşturduğu cookie yi okuyup tempdata ile ekrana yolluyoruz
            }
            return View();
        }
        public ActionResult CookieSil()
        {
            if (HttpContext.Request.Cookies["username"] != null)
            {
                HttpContext.Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(-1);
            }
            TempData["mesaj"] = "<div class='alert alert-danger'>Cookie Silindi!</div>";
            return RedirectToAction("Index");
        }
    }
}