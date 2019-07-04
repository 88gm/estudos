using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_CRUD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "teste_parametro",
                "sobre/{id}/teste",
                new { controller = "Home", action = "about", id = 0}
                );

            routes.MapRoute(
                "Sobre",
                "Sobre",
                new {controller = "Home", action = "about"}
                );

            routes.MapRoute(
                "Contato",
                "Contato",
                new {controller = "Home", action = "contact"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
