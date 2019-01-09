using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Newses;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class RemoveNewsTagRequest
    {
        public RemoveNewsTagRequest(NewsTagViewModel newsTagViewModel)
        {
            NewsTagViewModel = newsTagViewModel;
        }
        internal NewsTagViewModel NewsTagViewModel { get; set; }
    }
}
