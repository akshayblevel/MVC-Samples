using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _9ContentResult.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ContentResult Index()
        {
            return Content("Hi Akshay Patel", "text/plain", Encoding.UTF8);
        }

    }
}

 