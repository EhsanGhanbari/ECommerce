namespace ECommerce.CrossCutting.Authentication
{
    public interface ILocalAuthenticationService
    {
        UserAuthentication Login(string email, string password);
        UserAuthentication RegisterUser(string email, string password);
    }
}
