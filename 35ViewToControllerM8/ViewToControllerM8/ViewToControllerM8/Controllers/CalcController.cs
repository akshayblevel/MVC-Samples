using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewToControllerM8.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            int result = Convert.ToInt32(Request.Form.Get("Text1")) + Convert.ToInt32(Request.Form.Get("Text2"));
            ViewData["Sum"] = result;
            return View("Index");
        }
    }
}