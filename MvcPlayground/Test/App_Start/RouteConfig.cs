using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Test.Controllers;

namespace Test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //    name: "UsersProfiles",
            //    url: "{controller}/{action}/users/{username}",
            //    defaults: new
            //    {
            //        controller = nameof(HomeController),
            //        action = nameof(HomeController.UserProfile),
            //        username = UrlParameter.Optional
            //    }
            //);

            routes.MapRoute(
                name: "UsersProfiles",
                url: "users/{username}",
                defaults: new
                {
                    controller = nameof(HomeController),
                    action = nameof(HomeController.Profiles),
                    username = UrlParameter.Optional
                }
             );

            routes.MapRoute(
              name: "Comments",
              url: "comments/{controller}/{action}/{page}",
              defaults: new
              {
                  controller = "Home",
                  action = nameof(HomeController.LoadComments),
                  page = UrlParameter.Optional
              }
          );

            routes.MapRoute(
              name: "TestHomePage",
              url: "home",
              defaults: new
              {
                  controller = "Home",
                  action = nameof(HomeController.TestHomePage),
              }
          );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

           );
        }
    }
}
