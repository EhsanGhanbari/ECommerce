using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class UpdateNewsResponse : BaseResponse
    {
        public NewsViewModel NewsViewModel { get; set; }
    }
}
