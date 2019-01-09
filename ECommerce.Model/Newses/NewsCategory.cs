using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Newses
{
    public class NewsCategory : Category
    {
        
        private readonly IList<NewsCategory> _newsCategories;

        public NewsCategory(IEnumerable<NewsCategory> newsCategories)
        {
            _newsCategories = new List<NewsCategory>(newsCategories);
        }


        public IList<NewsCategory> NewsCategories
        {
            get { return _newsCategories; }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
