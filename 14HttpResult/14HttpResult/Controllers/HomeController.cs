using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _14HttpResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public HttpStatusCodeResult httpStatusCodeResult()
        {
            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Currently Server is Busy.");
        }
        [HttpGet]
        public HttpUnauthorizedResult httpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult("Access Is Denied");
        }
        [HttpGet]
        public HttpNotFoundResult httpNotFoundResult()
        {
            return HttpNotFound("File Not Found");
        }
	}
}