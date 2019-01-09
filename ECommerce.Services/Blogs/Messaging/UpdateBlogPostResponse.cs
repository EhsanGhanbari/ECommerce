


using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class UpdateBlogPostResponse : BaseResponse
    {
        public BlogViewModel BlogViewModel { get; set; }
    }
}
