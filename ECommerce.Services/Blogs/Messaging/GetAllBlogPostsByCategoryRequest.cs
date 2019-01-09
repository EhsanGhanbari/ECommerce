using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogPostsByCategoryRequest
    {
        internal BlogViewModel BlogViewModel { get; set; }

        public GetAllBlogPostsByCategoryRequest(BlogViewModel blogViewModel)
        {
            BlogViewModel = blogViewModel;
        }

        public string CategorName { get; set; }
    }
}
