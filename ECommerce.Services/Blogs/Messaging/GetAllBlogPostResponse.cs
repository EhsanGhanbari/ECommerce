using System.Collections.Generic;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogPostResponse : BaseResponse
    {
        public IEnumerable<BlogViewModel> BlogPostViewModel { get; set; }
    }
}
