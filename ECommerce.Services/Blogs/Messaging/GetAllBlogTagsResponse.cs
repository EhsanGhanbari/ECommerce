using System.Collections.Generic;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogTagsResponse : BaseResponse
    {
        public IEnumerable<BlogTagViewModel> BlogTagViewModels { get; set; }
    }
}
