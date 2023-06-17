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
    }
}