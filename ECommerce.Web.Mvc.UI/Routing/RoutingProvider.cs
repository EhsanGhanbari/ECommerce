using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ECommerce.Web.Mvc.UI.Routing
{
    public class RoutingProvider : IRoutingProvider
    {

        /// <summary>
        /// Register Blog Routes
        /// </summary>
        /// <param name="routes"></param>
        public void RegisterBlogRoutes(RouteCollection routes)
        {
            //Route to Support Blog
            routes.MapRoute("BlogRoute",
                            "Post/{year}/{month}/{day}/{postSlug}",
                            new
                            {
                                controller = "Blog",
                                action = "Post",
                                year = UrlParameter.Optional,
                                month = UrlParameter.Optional,
                                day = UrlParameter.Optional,
                                newsSlug = ""
                            },
                                  new[] { "Ecommerce.Web.Mvc.UI.Controllers" });
        }

        /// <summary>
        /// Register News Routes
        /// </summary>
        /// <param name="routes"></param>
        public void RegisterNewsRoutes(RouteCollection routes)
        {
            //Route to support News
            routes.MapRoute("NewsRoute",
                            "Post/{year}/{month}/{day}/{newsSlug}",
                            new
                            {
                                controller = "News",
                                action = "Post",
                                year = UrlParameter.Optional,
                                month = UrlParameter.Optional,
                                day = UrlParameter.Optional,
                                newsSlug = ""
                            },
                                  new[] { "Ecommerce.Web.Mvc.UI.Controllers" });
        }


    }
}