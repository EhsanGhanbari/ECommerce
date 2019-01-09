namespace ECommerce.CrossCutting.Authentication
{
    public interface IUserAuthenticationService
    {
        UserAuthentication Login(string email, string password);
        UserAuthentication RegisterUser(string email, string password);
    }
}
