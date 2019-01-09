using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetBlogPostResponse : BaseResponse
    {
        public BlogViewModel BlogViewModel { get; set; }
    }
}
