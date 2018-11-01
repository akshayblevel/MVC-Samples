using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16ViewToControllerM1.Controllers
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
        public ActionResult Index(FormCollection frm)
        {
            int result = Convert.ToInt32(frm[0]) + Convert.ToInt32(frm[1]);
            ViewData["Sum"] = result;
            return View();
        }
	}
}