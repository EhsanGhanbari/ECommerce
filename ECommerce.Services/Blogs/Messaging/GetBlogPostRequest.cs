using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetBlogPostRequest
    {
        /// <summary>
        /// constructor that has the BlogViewModel as parameter
        /// </summary>
        /// <param name="blogViewModel"></param>
        public GetBlogPostRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }


        /// <summary>
        /// Constructor that gets the year + month + year + postSlug as parameter 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="postSlug"></param>
        public GetBlogPostRequest(int year, int month, int day, string postSlug)
        {
            Year = year;
            Month = month;
            Day = day;
            PostSlug = postSlug;
        }


        internal BlogViewModel BlogViewModel { get; private set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string PostSlug { get; set; }

    }
}
