using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogPostRequest
    {
        public GetAllBlogPostRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }


        /// <summary>
        /// Constroctor to support archive of the Blog to
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public GetAllBlogPostRequest(int year, int month)
        {
            Year = year;
            Month = month;
        }


        internal BlogViewModel BlogViewModel { get; private set; }
        internal int Year { get; set; }
        internal int Month { get; set; }

    }
}
