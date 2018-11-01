using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22ViewToControllerM7.Controllers
{
    public class CalcController : Controller
    {
        //
        // GET: /Calc/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            int result = Convert.ToInt32(ValueProvider.GetValue("Text1").AttemptedValue) 
                + Convert.ToInt32(ValueProvider.GetValue("Text2").AttemptedValue);
            ViewData["Sum"] = result;
            return View("Index");
        }
	}
}