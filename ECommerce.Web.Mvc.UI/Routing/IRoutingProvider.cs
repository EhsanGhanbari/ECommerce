using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ECommerce.Web.Mvc.UI.Routing
{
    public interface IRoutingProvider
    {
        void RegisterBlogRoutes(RouteCollection routes);
        void RegisterNewsRoutes(RouteCollection routes);


    }
}