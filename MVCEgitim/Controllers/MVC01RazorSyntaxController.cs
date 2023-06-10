using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC01RazorSyntaxController : Controller
    {
        // GET: MVC01RazorSyntax
        public ActionResult Index() // bir action a view eklemek için Index() ismine sağ tık add view diyerek açılan pencereden isim verip ekleyebiliriz veya direk views klasörüne sağ tık diyerek de ekleyebiliriz.
        {
            return View();
        }
    }
}