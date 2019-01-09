using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Blogs;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class GetAllBlogCategoriesRequest
    {
        internal BlogCategoryViewModel BlogCategoryViewModel { get; set; }

        public GetAllBlogCategoriesRequest(BlogCategoryViewModel blogCategoryViewModel)
        {
            BlogCategoryViewModel = blogCategoryViewModel;
        }
    }
}
