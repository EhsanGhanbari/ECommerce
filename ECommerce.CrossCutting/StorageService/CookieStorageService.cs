using System;
using System.Web;

namespace ECommerce.CrossCutting.StorageService
{
    public class CookieStorageService : ICookieStorageService
    {
        public void Save(string key, string value, DateTime expires)
        {
            var cookie = HttpContext.Current.Response.Cookies[key];
            if (cookie != null)
                cookie.Value = value;

            var httpCookie = HttpContext.Current.Response.Cookies[key];
            if (httpCookie != null)
                httpCookie.Expires = expires;
        }

        public string Retrieve(string key)
        {
            var cookie = HttpContext.Current.Request.Cookies[key];
            return cookie != null ? cookie.Value : "";
        }
    }
}
