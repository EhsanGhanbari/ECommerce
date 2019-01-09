using System.Collections.Generic;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetAllNewsResponse :BaseResponse
    {
        public IEnumerable<NewsViewModel> NewsViewModels { get; set; } 
    }
}
