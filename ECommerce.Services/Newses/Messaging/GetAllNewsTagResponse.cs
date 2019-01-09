using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetAllNewsTagResponse : BaseResponse
    {
        public IEnumerable<NewsTagViewModel> NewsTagViewModels { get; set; }
    }
}
