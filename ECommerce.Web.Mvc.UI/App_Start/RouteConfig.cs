
using System.Web.Mvc;
using System.Web.Routing;
using ECommerce.Web.Mvc.UI.Routing;

namespace ECommerce.Web.Mvc.UI.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Ignore Urls
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //Default Route Definition
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "Ecommerce.Web.Mvc.UI.Controllers" });

        }
    }
}