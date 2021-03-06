﻿using System.Web.Mvc;
using System.Web.Routing;

namespace BGL.GitHubRepos.Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "GiHubUserProfile", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
