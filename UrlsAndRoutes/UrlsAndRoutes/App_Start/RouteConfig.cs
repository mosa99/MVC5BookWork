﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("NewRoute", "App/Do{action}", new { controller = "Home" });

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}",
            new
            {
                controller = "Home",
                action = "Index",
                id = UrlParameter.Optional
            });



        }//public static void RegisterRoutes(RouteCollection routes)
    }
}
