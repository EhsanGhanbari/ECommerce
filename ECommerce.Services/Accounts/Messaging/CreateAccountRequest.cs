namespace ECommerce.Services.Accounts.Messaging
{
    public class CreateAccountRequest
    {
        //Sould check the chaptcha code or somthing else
        public bool IdentityToken { get; set; }
    }
}
