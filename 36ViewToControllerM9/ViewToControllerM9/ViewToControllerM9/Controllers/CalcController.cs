﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewToControllerM9.Controllers
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
            int result = Convert.ToInt32(Request.Params["Text1"]) + Convert.ToInt32(Request.Params["Text2"]);
            ViewData["Sum"] = result;
            return View("Index");
        }
    }
}