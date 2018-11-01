using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10RedirectResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public RedirectResult redirect()
        {
            return Redirect("About");
        }

        [HttpGet]
        public RedirectResult redirectPermanent()
        {
            return RedirectPermanent("About"); //301
        }

        public ActionResult About()
        {
            return View();
        }
	}
}