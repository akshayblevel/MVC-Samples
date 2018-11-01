using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _35ControllerToController.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            TempData["temp"] = Session.SessionID;

            return RedirectToAction("Index", "Second");
        }
    }
}