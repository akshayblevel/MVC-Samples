using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15FileResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public FileResult downloadFile()
        {
            return new FilePathResult("~\\File\\vocabulary.docx",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }

        [HttpGet]
        public FileResult downloadTextFile()
        {
            return File("~\\File\\MPN.txt", "text/plain");

        }

        //[HttpGet]
        //public FileContentResult downloadFileContent()
        //{
        //    MemoryStream stream = Utility.GetGoGreenImage();

        //    byte[] biteArray = new byte[stream.Length];

        //    return File(biteArray, "image/png", "automation.png");

        //}

        //[HttpGet]
        //public FileStreamResult fileStreamContent()
        //{
        //    Stream stream = Utility.GetGoGreenImage();

        //    return new FileStreamResult(stream, "image/png");
        //}
	}
}