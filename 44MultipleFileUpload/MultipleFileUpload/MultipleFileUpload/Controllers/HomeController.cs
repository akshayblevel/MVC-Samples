using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MultipleFileUpload.Controllers
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
            if (FileUpload1.ContentLength > 0)
            {
                HttpFileCollectionBase files = Request.Files;
                DataTable dt = new DataTable { Columns = { new DataColumn("Path") } };
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFileBase file = files[i];
                    string path = Server.MapPath("~") + "\\Images\\" + file.FileName;
                    dt.Rows.Add(file.FileName);
                    file.SaveAs(path);
                }
                ViewData.Model = dt.AsEnumerable();
            }
            return View();
        }
    }
}