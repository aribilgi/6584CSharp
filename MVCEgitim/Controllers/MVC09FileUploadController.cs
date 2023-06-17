using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC09FileUploadController : Controller
    {
        // GET: MVC09FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya) // MVC de post işlemi yapıldığında bu metot a form içindeki file nesnesini HttpPostedFileBase sınıfından bir nesne oluşturarak dosyaya ulaşabiliyoruz
        {
            if (dosya != null)
            {
                dosya.SaveAs(Server.MapPath("/Images/" + dosya.FileName));
                ViewBag.ResimAdi = dosya.FileName;
            }
            else ViewData["message"] = "Lütfen bir dosya seçiniz!";
            return View();
        }
    }
}