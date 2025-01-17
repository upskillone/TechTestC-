﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AnyCo_Entertain
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Orders",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Orders", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
