using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19ViewToControllerM4.Controllers
{
    public class CalcController : Controller
    {
        //
        // GET: /Calc/
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Addition")]
        public ActionResult Add(FormCollection frm)
        {
            int result = Convert.ToInt32(frm[0]) + Convert.ToInt32(frm[1]);
            ViewData["Sum"] = result;
            return View("Index");
        }
	}
}