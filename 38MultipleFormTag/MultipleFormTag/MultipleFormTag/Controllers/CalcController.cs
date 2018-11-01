using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleFormTag.Controllers
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
            int result = Convert.ToInt32(Request.Form["Text1"]) + Convert.ToInt32(Request.Form["Text2"]);
            ViewData["Add"] = result;
            return View("Index");
        }

        [HttpPost]
        public ActionResult Sub()
        {
            int result = Convert.ToInt32(Request.Form.Get("Text1")) - Convert.ToInt32(Request.Form.Get("Text2"));
            ViewData["Sub"] = result;
            return View("Index");
        }

        [HttpPost]
        public ActionResult Mul()
        {
            int result = Convert.ToInt32(Request.Params["Text1"]) * Convert.ToInt32(Request.Params["Text2"]);
            ViewData["Mul"] = result;
            return View("Index");
        }

        [HttpPost]
        public ActionResult Div()
        {
            int result = Convert.ToInt32(Request["Text1"]) / Convert.ToInt32(Request["Text2"]);
            ViewData["Div"] = result;
            return View("Index");
        }
    }
}