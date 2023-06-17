using MVCEgitim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        // GET: MVC08ViewResults
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FarkliViewDondur() // MVC08ViewResults controller ındaki FarkliViewDondur isimli metot çalıştırılırsa
        {
            return View("Index"); // geriye FarkliViewDondur isimli bir ekran yerine index isimli view ı da gönderebiliriz.
        }
        public ActionResult Yonlendir()
        {
            // Bir action a istek gönderildiğinde farklı bir sayfaya yönlendirme yapabiliriz

            //return Redirect("/Home"); // uygulamayı anasayfa yönlendir
            return Redirect("https://www.google.com.tr/?hl=tr"); // uygulamayı google a yönlendir
        }
        public ActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // bu metot çalıştığında RedirectToAction metodu uygulamayı Index action ına yönlendirir
            return RedirectToAction("Index", "Home"); // bu metot çalıştığında uygulama ana sayfanın index metoduna yönlendirilir
        }
        public ActionResult RouteYonlendir()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index", id = 18 });
        }
        public PartialViewResult KategorileriGetirPartial() // Bir action işlemi sonucunda ActionResult kullanmak yerine direk geri dönüş türünü de belirtebiliriz 
        {
            return PartialView("_PartialMenu"); // PartialViewResult döneceğimizi belirttiğimiz için geriye bir PartialView dönmeliyiz. Parantez içerisine döndürmek istediğimiz partial adını yazıyoruz
        }
        public PartialViewResult KategorileriModelleGetir()
        {
            List<string> kategoriler = new List<string>() {
                "Elektronik", "Bilgisayar", "Telefon"
            };
            return PartialView("KategorileriModelleGetir", kategoriler);
        }
        public JavaScriptResult JsResult()
        {
            return JavaScript("alert('geriye JavaScript dönebildiğimiz metot çalıştı!')"); // geriye JavaScript dönebildiğimiz metot
        }
        public JsonResult JsonResult()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "mur@yimaz.co",
                Id = 25
            };
            return Json(kullanici, JsonRequestBehavior.AllowGet); // kullanici nesnesini json veri türüne çevirip geriye döndürdük. JsonRequestBehavior.AllowGet ile json u dışarı açmaya izin vermeliyiz yoksa güvenlik hatası alıyoruz!
        }
        public ContentResult XmlContentResult()
        {
            var xml = @"<urunler>
                <urun>
                    <Id>1</Id>
                    <UrunAdi>Mouse</UrunAdi>
                    <Fiyati>149</Fiyati>
                </urun>
                <urun>
                    <Id>2</Id>
                    <UrunAdi>Klavye</UrunAdi>
                    <Fiyati>349</Fiyati>
                </urun>
            </urunler>";
            return Content(xml, "application/xml");
        }
    }
}