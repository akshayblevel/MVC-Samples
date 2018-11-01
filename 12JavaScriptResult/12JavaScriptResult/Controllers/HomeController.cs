using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12JavaScriptResult.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JavaScriptResult javaScriptResult()
        {
           string js = @"var temp = document.getElementById('some-div');
                       temp.innerHTML='Akshay Patel - Updated By MVC';";

            return JavaScript(js);
        }
	}
}