using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _13JsonResult.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult jsonResult()
        {
            var employee = new { Id = 1, Name = "mahesh", City = "Baroda" };

            //JsonResult js = new JsonResult();
            //js.Data = employee;
            //js.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //js.ContentType = "application/json";
            //js.ContentEncoding = Encoding.UTF8;
            //return js;

            return Json(employee, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);

            //return new JsonResult() 
            //{
            //    ContentType = "application/json", JsonRequestBehavior = JsonRequestBehavior.AllowGet, Data = employee 
            //};
        }
	}
}