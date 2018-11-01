using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _37CustomActionResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataTable dt = DbProviderFactories.GetFactoryClasses();
            return new XmlResult(dt);
        }
    }
}