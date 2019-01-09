using System.Web;
using ECommerce.Web.Core.Controllers;
using FluentSecurity;

namespace ECommerce.Web.Core.Security
{
    public class FluentSecurityConfiguration  
    {
        public static void Configure()
        {
            SecurityConfigurator.Configure(configuration =>
            {
                configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);

              //  configuration.IgnoreMissingConfiguration();

              //  configuration.For<HomeController>().Ignore();
                configuration.For<BaseController>().Ignore();

            });
        }
    }
}