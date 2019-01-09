using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class UpdateBlogPostRequest
    {
        public BlogViewModel BlogViewModel { get; private set; }

        public UpdateBlogPostRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }
    }
}
