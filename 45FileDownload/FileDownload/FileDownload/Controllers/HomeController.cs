using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
namespace FileDownload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Download()
        {
            string path = Server.MapPath("~/Images/");
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles("*.*");
            List<string> lst = new List<string>(files.Length);
            foreach (var item in files)
            {
                lst.Add(item.Name);
            }
            return View(lst);
        }
        public ActionResult DownloadFile(string filename)
        {
            if (Path.GetExtension(filename) == ".png")
            {
                string fullPath = Path.Combine(Server.MapPath("~/Images/"), filename);
                return File(fullPath, "Images/png");
            }
            else
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.Forbidden);
        }
    }
}