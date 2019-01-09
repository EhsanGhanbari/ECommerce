using ECommerce.Services.Accounts.ViewModel;

namespace ECommerce.Services.Accounts.Messaging
{
    public class CreateAccountResponse :BaseResponse
    {
        public AccountViewModel AccountViewModel { get; set; }
    }
}
