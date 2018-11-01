using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _27ErrorHandlingM5.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HandleError()]
        public ActionResult Index()
        {
            string name = Session["temp"].ToString();
            return View();
        }
	}
}