using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3DtInViewData.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {

            DataTable dt = new DataTable();
            dt = System.Data.Common.DbProviderFactories.GetFactoryClasses();

            ViewData.Model = dt.AsEnumerable();

            return View();
        }
	}
}