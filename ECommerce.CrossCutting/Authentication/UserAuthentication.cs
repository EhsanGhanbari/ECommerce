namespace ECommerce.CrossCutting.Authentication
{
    public class UserAuthentication
    {
        public string AuthenticationToken { get; set; }
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
