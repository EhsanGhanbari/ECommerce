using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class RemoveNewsRequest
    {
        internal NewsViewModel NewsViewModel { get; set; }

        public RemoveNewsRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }

    }
}
