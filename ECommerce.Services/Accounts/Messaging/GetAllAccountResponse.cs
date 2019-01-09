using System.Collections.Generic;
using ECommerce.Services.Accounts.ViewModel;

namespace ECommerce.Services.Accounts.Messaging
{
    public class GetAllAccountResponse:BaseResponse
    {
       public  IEnumerable<AccountViewModel> AccountViewModels { get; set; } 
    }
}
