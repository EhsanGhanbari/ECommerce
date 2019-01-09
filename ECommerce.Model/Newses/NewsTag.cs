using System;
using System.Collections.Generic;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Newses
{
    public sealed class NewsTag : Tag
    {
        private readonly IList<NewsTag> _newsTags;

        public NewsTag(IEnumerable<NewsTag> newsTags)
        {
            _newsTags = new List<NewsTag>(newsTags);
        }

        public NewsTag(string name, int count)
        {
            Count = count;
            Name = name;
        }

        /// <summary>
        /// List of news Tags
        /// </summary>
        public IList<NewsTag> NewsTags
        {
            get { return _newsTags; }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
