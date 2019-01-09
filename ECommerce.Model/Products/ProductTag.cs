using System;
using System.Collections.Generic;
using System.Diagnostics;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Products
{
    public class ProductTag : Tag, IProductAttribute
    {

        private readonly string _name;
        private readonly bool _showOnHomePage;
        private readonly bool _deleted;
        private readonly IList<ProductTag> _productTags;


        public ProductTag(IEnumerable<ProductTag> productTags)
        {
            _productTags = new List<ProductTag>(productTags);
        }

        public ProductTag(string name, bool showOnHomePage, bool deleted)
        {
            _name = name;
            _showOnHomePage = showOnHomePage;
            _deleted = deleted;
        }


        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<ProductTag> ProductTags
        {
            get { return _productTags; }
        } 


        /// <summary>
        /// Product tag name
        /// </summary>
        public new virtual string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// show on page, managable by the user
        /// </summary>
        public virtual bool ShowOnHomePage
        {
            get { return _showOnHomePage; }
        }


        /// <summary>
        /// tha tag is deleted or not!
        /// </summary>
        public virtual bool Deleted
        {
            get { return _deleted; }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

