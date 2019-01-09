using System;
using System.Collections.Generic;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Blogs
{
    public class BlogCategory : Category
    {
        private readonly IList<BlogCategory> _blogCategory;

        public BlogCategory(IEnumerable<BlogCategory> blogCategories)
        {
            _blogCategory = new List<BlogCategory>(blogCategories);
        }

        public IEnumerable<BlogCategory> BlogCategories
        {
            get { return _blogCategory; }
        }

        
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
