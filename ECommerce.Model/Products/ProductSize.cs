using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductSize : ValueObjectBase, IProductAttribute
    {
        private readonly string _name;
        private readonly bool _showOnHomePage;
        private readonly bool _deleted;

        public ProductSize(bool deleted)
        {
            _deleted = deleted;
        }

        public ProductSize(string name, bool showOnHomePage)
        {
            _name = name;
            _showOnHomePage = showOnHomePage;
        }


        /// <summary>
        /// Size of the Product
        /// </summary>
        public virtual string Name {
            get
            {
                return _name;
            }
        }

        public bool ShowOnHomePage
        {
            get
            {
                return _showOnHomePage;
            }
        }

        public bool Deleted
        {
            get
            {
                return _deleted;
            }
        }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
