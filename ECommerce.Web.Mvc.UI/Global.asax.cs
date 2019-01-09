using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using ECommerce.Services;
using ECommerce.Web.Core.IoCBootstrap;
using ECommerce.Web.Mvc.UI.App_Start;
using FluentValidation.Mvc;


namespace ECommerce.Web.Mvc.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        

            IoC.Initialize();
            AutoMapperBootStrapper.ConfigureAutoMapper();
            FluentValidationModelValidatorProvider.Configure();
            //FluentSecurityConfiguration.Configure();
            //PortableAreaRegistration.RegisterEmbeddedViewEngine();

        }
    }
}