using System.Web.Configuration;
using System.Web.Mvc;

namespace MVCEgitim.Controllers
{
    public class MVC13AppSettingController : Controller
    {
        // GET: MVC13AppSetting
        public ActionResult Index()
        {
            ViewBag.Usr = WebConfigurationManager.AppSettings["EmailUserName"];
            ViewBag.Pwd = WebConfigurationManager.AppSettings["EmailPassword"];
            return View();
        }
    }
}