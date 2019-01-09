namespace ECommerce.CrossCutting.Authentication
{
    public interface IFormsAuthentication
    {
        void SetAuthenticationToken(string token);
        string GetAuthenticationToken();
        void SignOut();
    }                
}
