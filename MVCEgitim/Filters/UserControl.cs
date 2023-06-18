using System.Web.Mvc;

namespace MVCEgitim.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usersession = filterContext.HttpContext.Session["deger"];
            var usercookie = filterContext.HttpContext.Request.Cookies["username"];
            if (usersession == null) {
                filterContext.Result = new RedirectResult("/MVC11Sessions?msg=AccessDenied");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}