using System;
using System.Collections.Generic;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Blogs
{
    public class BlogComment : Comment
    {
        public ICollection<Blog> Blogs { get; set; } 

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
