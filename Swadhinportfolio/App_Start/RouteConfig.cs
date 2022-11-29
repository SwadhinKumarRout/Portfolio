using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SRportfolio
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
               name: "Education",
               url: "{controller}/{action}",
               defaults: new { controller = "Education", action = "Education"}
           );

           routes.MapRoute(
          name: "Skill",
          url: "{controller}/{action}",
          defaults: new { controller = "Skill", action = "Skill"}
      );

            routes.MapRoute(
          name: "Experience",
          url: "{controller}/{action}",
          defaults: new { controller = "Experience", action = "Experience" }
      );
            routes.MapRoute(
  name: "Hobbies",
  url: "{controller}/{action}",
  defaults: new { controller = "Hobbies", action = "Hobbies" }
    );
        }
    }
}
