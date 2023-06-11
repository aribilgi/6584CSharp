using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        static List<Uye> uyeListesi = new List<Uye>()
        {
            new Uye(){ Ad = "Alp", Soyad = "Arslan", Email = "alp@arslan.com" },
            new Uye(){ Ad = "Murat", Soyad = "Yılmaz", Email = "mur@arslan.com" },
            new Uye(){ Ad = "Deniz", Soyad = "Gökçe", Email = "deniz@google.com" }
        };
        // GET: MVC05ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UyeListesi()
        {
            return View(uyeListesi);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Uye uye)
        {
            return View(uye);
        }
    }
}