using MVCEgitim.Filters;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC14FiltersController : Controller
    {
        // GET: MVC14Filters
        [UserControl] // bizim yazdığımız filtreyi ekledik böylece aşağıdaki index metoduna bir istek geldiğinde bir kontrol yapılacak ve UserControl içerisinde uyguladığımız şart yerine geliyorsa ekran açılacak aksi taktirde yine login sayfasına yönlendirilecek
        public ActionResult Index()
        {
            return View();
        }
    }
}