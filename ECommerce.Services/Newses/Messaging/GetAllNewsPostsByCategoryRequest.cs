using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetAllNewsPostsByCategoryRequest
    {
        public GetAllNewsPostsByCategoryRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }

        internal NewsViewModel NewsViewModel { get; set; }
    }
}
