using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase FileUpload1)
        {
            string path = Server.MapPath("~") + "\\Images\\" + FileUpload1.FileName;
            FileUpload1.SaveAs(path);
            ViewData["Path"] = FileUpload1.FileName;    
            return View();
        }
    }
}