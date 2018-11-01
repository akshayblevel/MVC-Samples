using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25ErrorHandlingM3.App_Start
{
    public class ErrorConfig
    {
        public static void RegisterFilter(GlobalFilterCollection filter)
        {
            filter.Add(new HandleErrorAttribute());
        }
    }
}