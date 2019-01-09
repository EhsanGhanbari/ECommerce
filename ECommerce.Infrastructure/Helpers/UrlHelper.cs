using System.Web;

namespace ECommerce.Infrastructure.Helpers
{
    public class UrlHelper
    {
        public static string Resolve(string resource)
        {
           
                return string.Format("{0}://{1}{2}{3}",
                                     HttpContext.Current.Request.Url.Scheme,
                                     HttpContext.Current.Request.ServerVariables["HTTP-HOST"],
                                     (HttpContext.Current.Request.ApplicationPath.Equals("/"))
                                         ? string.Empty
                                         : HttpContext.Current.Request.ApplicationPath,
                                     resource);
           
        }
    }
}
