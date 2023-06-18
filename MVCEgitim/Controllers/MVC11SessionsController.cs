using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC11SessionsController : Controller
    {
        // GET: MVC11Sessions
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "Admin" && sifre == "1236") // eğer ekrandan gönderilen değerler admin ve 1236 ise
            {
                Session["deger"] = "Admin"; // Bir session oluştur adı deger olsun ve üzerinde Admin verisini taşısın.
                TempData["mesaj"] = "<div class='alert alert-success'>Giriş Başarılı!</div>";
            }
            else
            {
                TempData["mesaj"] = "<div class='alert alert-danger'>Giriş Başarısız!</div>";
            }
            return View("Index");
        }
        public ActionResult SessionOku()
        {
            if (Session["deger"] != null)
            {
                TempData["mesaj"] = $"<div class='alert alert-success'>Hoşgeldin {Session["deger"]}</div>";
            }
            else
            {
                TempData["mesaj"] = "<div class='alert alert-danger'>Giriş Yapılmamış!</div>";
            }
            return View();
        }
        public ActionResult SessionSil()
        {
            if (Session["deger"] != null)
            {
                // Session["deger"] = null;
                HttpContext.Session.Remove("deger");
            }
            
            return RedirectToAction("Index");
        }
        public ActionResult KullaniciEkrani()
        {
            if (Session["deger"] == null)
                return RedirectToAction("Index");
            return View();
        }
    }
}