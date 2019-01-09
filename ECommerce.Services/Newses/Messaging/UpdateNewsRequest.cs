using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class UpdateNewsRequest
    {
        internal NewsViewModel NewsViewModel { get; private set; }

        public UpdateNewsRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }

    }
}
