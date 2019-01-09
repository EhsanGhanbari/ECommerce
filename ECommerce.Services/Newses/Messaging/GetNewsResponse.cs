using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetNewsResponse : BaseResponse
    {
        public NewsViewModel NewsViewModel { get; set; }
    }
}
