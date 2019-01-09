using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetAllNewsRequest
    {

        internal NewsViewModel NewsViewModel { get; private set; }
        internal int Year { get; private set; }
        internal int Month { get; private set; }

        public GetAllNewsRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }

        public GetAllNewsRequest(int year, int month)
        {
            Year = year;
            Month = month;
        }

    }
}
