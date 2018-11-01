using _32RequiredFieldValidaterClientSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _32RequiredFieldValidaterClientSide.Controllers
{
    public class EmpolyeeController : Controller
    {
        // GET: Empolyee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            return View();
        }
    }
}