using System.Collections.Generic;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogPostByTagResponse : BaseResponse
    {
        public IEnumerable<BlogViewModel> BlogViewModel { get; set; }
    }
}
