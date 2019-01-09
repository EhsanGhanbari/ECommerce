using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Commons;

namespace ECommerce.Model.Products
{
    public class ProductCategory : Category, IProductAttribute
    {

        private readonly bool _deleted;
        private readonly bool _showOnHomePage;
        private readonly IList<ProductCategory> _productCategories;

        public ProductCategory(IEnumerable<ProductCategory> productCategories)
        {
            _productCategories = new List<ProductCategory>(productCategories);
        }

        public ProductCategory(bool showOnHomePage, bool deleted)
        {
            _showOnHomePage = showOnHomePage;
            _deleted = deleted;
        }


        public IList<ProductCategory> ProductCategories
        {
            get { return _productCategories; }
        }


        /// <summary>
        /// Product category name
        /// </summary>
        public override string Name
        {
            get;
            set;
        }


        /// <summary>
        /// show on page, managable by the user
        /// </summary>
        public virtual bool ShowOnHomePage
        {
            get { return _showOnHomePage; }
        }

        /// <summary>
        /// Product is deleted or not
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
