using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class CreateNewsResponse : BaseResponse
    {
        public NewsViewModel NewsViewModel { get; set; }
    }
}
