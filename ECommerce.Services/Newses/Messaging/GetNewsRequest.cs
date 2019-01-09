using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses.Messaging
{
    public class GetNewsRequest
    {
        internal NewsViewModel NewsViewModel { get; private set; }
        internal int Year { get; private set; }
        internal int Month { get; private set; }
        internal int Day { get; private set; }
        internal string NewsSlug { get; private set; }

        public GetNewsRequest(NewsViewModel newsViewModel)
        {
            NewsViewModel = newsViewModel;
        }

        public GetNewsRequest(int year, int month, int day,string newsSlug)
        {
            Year = year;
            Month = month;
            Day = day;
            NewsSlug = newsSlug;
        }
       
    }
}
