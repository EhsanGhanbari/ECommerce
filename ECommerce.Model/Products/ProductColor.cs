using System;
using System.IO;
using System.Security.AccessControl;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductColor : ValueObjectBase ,IProductAttribute
    {
        
        private readonly string _name;
        private readonly bool _showOnHomePage;

        public ProductColor(string name, bool showOnHomePage)
        {
            _name = name;
            _showOnHomePage = showOnHomePage;
        }

        /// <summary>
        /// Color
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
        }

        public bool ShowOnHomePage
        {
            get { return _showOnHomePage; }
        }

        public bool Deleted { get; private set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
