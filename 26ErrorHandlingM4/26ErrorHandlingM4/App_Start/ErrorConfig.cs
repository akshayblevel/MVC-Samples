using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26ErrorHandlingM4.App_Start
{
    public class ErrorConfig
    {
        public static void RegisterFilter(GlobalFilterCollection filter)
        {
            HandleErrorAttribute error = new HandleErrorAttribute();
            error.View = "Help";
            filter.Add(error);
        }
    }
}