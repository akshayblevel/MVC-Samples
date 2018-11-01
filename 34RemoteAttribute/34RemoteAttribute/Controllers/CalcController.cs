using _34RemoteAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _34RemoteAttribute.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Calculate cal)
        {
            return View();
        }

        [HttpGet]
        public ActionResult IsValid(string No2)
        {
            if (Convert.ToInt32(No2) % 2 == 0)
                return Json(true, JsonRequestBehavior.AllowGet);
            else
                return Json("Only Even Number", JsonRequestBehavior.AllowGet);
        }
    }
}