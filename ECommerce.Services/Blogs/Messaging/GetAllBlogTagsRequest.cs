using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogTagsRequest
    {
        public BlogTagViewModel BlogTagViewModel { get; set; }

        public GetAllBlogTagsRequest(BlogTagViewModel blogTagViewModel)
        {
            BlogTagViewModel = blogTagViewModel;
        }
    }
}
