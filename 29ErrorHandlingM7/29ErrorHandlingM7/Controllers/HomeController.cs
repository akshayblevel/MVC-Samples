using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _29ErrorHandlingM7.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            string name = Session["temp"].ToString();
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            //base.OnException(filterContext);
            if (filterContext.ExceptionHandled)
            {
                return;
            }
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };
            //filterContext.ExceptionHandled = true;
        }    
	}
}