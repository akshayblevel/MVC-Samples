﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24ErrorHandlingM2.Controllers
{
    [HandleError()]
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            string name = Session["temp"].ToString();
            return View();
        }
	}
}