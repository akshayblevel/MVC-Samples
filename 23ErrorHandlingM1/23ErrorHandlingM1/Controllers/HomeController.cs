using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23ErrorHandlingM1.Controllers
{
    public class HomeController : Controller
    {
        [HandleError()]
        public ActionResult Index()
        {
            string name = Session["temp"].ToString();
            return View();
        }
	}
}