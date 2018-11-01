using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomActionResult
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //ViewEngines.Engines.RemoveAt(0);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
