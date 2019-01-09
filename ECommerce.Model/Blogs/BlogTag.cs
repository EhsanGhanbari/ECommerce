using System;
using System.Collections.Generic;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Blogs
{
    public sealed class BlogTag : Tag
    {
        private readonly IList<BlogTag> _blogTags;
        private readonly IList<Blog> _blogs; 

        public BlogTag()
        {
        }

        public BlogTag(IEnumerable<BlogTag> blogTags)
        {
            _blogTags = new List<BlogTag>(blogTags);
        }
        
        /// <summary>
        /// Blog Tags
        /// </summary>
        public IEnumerable<BlogTag> BlogTags
        {
            get { return _blogTags; }
        }

        public string Name { get; set; }
        public IList<Blog> blogs
        {
            get { return _blogs; }
        }

        protected override void Validate()
        {
            if (Name == null)
                AddBrokenRule(BlogTagBusinessRule.BodyRequired);
        }
    }
}
