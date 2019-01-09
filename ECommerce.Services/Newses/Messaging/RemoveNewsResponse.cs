

using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class RemoveNewsResponse :BaseResponse
    {
       public NewsViewModel NewsPost { get; set; }
    }
}
