using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;

namespace CustomActionResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var temp = ViewEngines.Engines;
            DataTable dt = DbProviderFactories.GetFactoryClasses();
            return new  XmlResult(dt);
        }

        public ActionResult Home()
        {
            return View("Home");
        }
    }
}