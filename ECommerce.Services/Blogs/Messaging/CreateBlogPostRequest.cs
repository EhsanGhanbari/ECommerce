
using System.Collections.Generic;
using System.Diagnostics;
using ECommerce.Model.Blogs;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class CreateBlogPostRequest
    {
        internal BlogViewModel BlogViewModel { get; private set; }
        public IEnumerable<BlogCategory> BlogCategories { get; set; }
        public IEnumerable<BlogTag> BlogTags { get; set; }

        public CreateBlogPostRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }

        public CreateBlogPostRequest(IEnumerable<BlogCategory> blogCategories, IEnumerable<BlogTag> blogTags)
        {
            BlogCategories = new List<BlogCategory>(blogCategories);
            BlogTags = new List<BlogTag>(blogTags);
        }
    }
}
