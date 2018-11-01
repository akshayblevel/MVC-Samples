using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace CustomActionResult
{
    public class XmlResult : ActionResult
    {
        private DataTable _dt;
        public XmlResult(DataTable dt)
        {
            _dt = dt;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/xml";

            XmlDataDocument dataDoc = new XmlDataDocument();
            DataSet ds = new DataSet();
            ds.Tables.Add(_dt);
            string str = ds.GetXml();

            response.Write(str);
        }
    }
}