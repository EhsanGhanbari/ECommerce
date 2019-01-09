using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Blogs;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs.Messaging
{
    public class RemoveBlogTagResponse :BaseResponse
    {
        public BlogTagViewModel BlogTagViewModel { get; set; }
    }
}
