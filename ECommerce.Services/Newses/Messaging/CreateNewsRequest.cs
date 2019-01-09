using System.Collections.Generic;
using ECommerce.Model.Newses;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class CreateNewsRequest
    {
        public CreateNewsRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }


        internal NewsViewModel NewsViewModel { get; private set; }
        internal IEnumerable<NewsTag> NewsTags { get; private set; }
        internal IEnumerable<NewsCategory> NewsCategories { get; private set; }
     }
}