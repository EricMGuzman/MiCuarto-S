using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MiCuarto_S
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Transacciones",
                "{controller}/{action}/{id}",
                new { controller = "Transaction", action = "Index", id = UrlParameter.Optional}
             );

            routes.MapRoute(
                "Presupuesto",
                "{controller}/{action}/{id}",
                new { controller = "Presupuesto", action = "Index", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                "Opciones",
                "{controller}/{action}/{id}",
                new { controller = "Opciones", action = "Index", id = UrlParameter.Optional }
             );


            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
