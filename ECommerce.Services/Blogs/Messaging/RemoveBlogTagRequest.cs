using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class RemoveBlogTagRequest
    {
        internal BlogTagViewModel BlogTagViewModel { get; private set; }

        public RemoveBlogTagRequest(BlogTagViewModel blogTagViewModel)
        {
            BlogTagViewModel = blogTagViewModel;
        }
    }
}
