﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KardexGPS
{
    public static class WebApiConfig
    {
        public static string UrlPrefix { get { return "api"; } }

        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
