using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        // GET: MVC03DataTransfer
        public ActionResult Index(string kelime, string fiyat) // get metoduyla query string üzerinden gönderilen veriyi bu şekilde parantez içine yazarak yakalayabiliriz. Burada önemli nokta form içerisindeki inputlara verdiğimiz name(isim) değeri neyse o isimle dilediğimiz kadar alan ekleyebiliriz.
        {
            // MVC de 3 temel yöntemle view a veri gönderebiliriz
            // 1- Viewbag
            ViewBag.UrunKategorisi = "Bilgisayar";
            // 2- Viewdata
            ViewData["UrunAdi"] = "Casper Monitör";
            // 3- TempData
            TempData["UrunFiyati"] = 99.90;

            ViewBag.Kelime = kelime;
            ViewBag.Fiyat = fiyat;
            return View();
        }
        [HttpPost] // aşağıdaki index metodunun sayfadaki post işleminden sonra çalışması gerektiğini bu attribute ile belirtiyoruz
        public ActionResult Index(string text1, string ddlListe, bool cbOnay, FormCollection formCollection) // formCollection nesnesi ekrandaki form elementi içerisindeki alanlara ulaşmamızı sağlar
        {
            // 1. Yöntem parametrelerden gelen veriler
            ViewBag.Mesaj = "textbox dan gelen veri : " + text1;
            ViewBag.MesajListe = "dropdownlist den gelen veri : " + ddlListe;
            TempData["Tdata"] = "checkbox dan seçilen değer : " + cbOnay;

            // 2. Yöntem formCollection dan gelen veriler
            ViewBag.Mesaj2 = "textbox dan gelen veri : " + formCollection["text1"];
            ViewBag.MesajListe2 = "dropdownlist den gelen veri : " + formCollection["ddlListe"];
            TempData["Tdata2"] = "checkbox dan seçilen değer : " + formCollection.GetValues("cbOnay")[0]; // checkbox için

            // 3. Yöntem Request Form dan gelen veriler
            ViewBag.Mesaj3 = "textbox dan gelen veri : " + Request.Form["text1"];
            ViewBag.MesajListe3 = "dropdownlist den gelen veri : " + Request.Form["ddlListe"];
            TempData["Tdata3"] = "checkbox dan seçilen değer : " + Request.Form.GetValues("cbOnay")[0]; // checkbox için
            return View();
        }
    }
}