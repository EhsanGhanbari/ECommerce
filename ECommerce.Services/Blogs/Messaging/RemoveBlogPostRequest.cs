using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class RemoveBlogPostRequest
    {
        internal BlogViewModel BlogViewModel { get; private set; }

        public RemoveBlogPostRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }

    }
}
