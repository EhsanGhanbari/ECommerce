using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductBrand : ValueObjectBase, IProductAttribute
    {
        private readonly string _name;
        private readonly bool _showOnHomePage;
        private readonly bool _deleted;

        public ProductBrand(bool deleted)
        {
            _deleted = deleted;
        }


        public ProductBrand(string name, bool showOnHomePage)
        {
            _name = name;
            _showOnHomePage = showOnHomePage;
        }


        /// <summary>
        /// Brnad Name 
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// show the brand on home page or not
        /// </summary>
        public virtual bool ShowOnHomePage
        {
            get { return _showOnHomePage; }
        }


        /// <summary>
        /// brand is deleted or not
        /// </summary>
        public bool Deleted
        {
            get { return _deleted; }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }


    }
}
