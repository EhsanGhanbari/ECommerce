using System.Web;
using System.Web.Security;
using ECommerce.CrossCutting.Authentication;

namespace ECommerce.CrossCutting.Authentication
{
    public class AuthenticationFactory : IFormsAuthentication
    {
        public void SetAuthenticationToken(string token)
        {
            FormsAuthentication.SetAuthCookie(token, false);
        }

        public string GetAuthenticationToken()
        {
            return HttpContext.Current.User.Identity.Name;
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
