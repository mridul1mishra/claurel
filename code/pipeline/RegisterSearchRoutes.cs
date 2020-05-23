using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using ExcelDataReader.Log;

namespace code.pipeline
{
    public class RegisterSearchRoutes
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("PostNewForm", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
        }
    }
}