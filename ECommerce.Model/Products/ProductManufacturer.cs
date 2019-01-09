using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductManufacturer : ValueObjectBase, IProductAttribute
    {
        
        private readonly string _name;
        private readonly bool _shoOnHomePage;
        private readonly bool _deleted;


        public ProductManufacturer(bool deleted)
        {
            _deleted = deleted;
        }

        public ProductManufacturer(string name, bool showOnHomePage)
        {
            _name = name;
            _shoOnHomePage = showOnHomePage;
        }

        /// <summary>
        /// Manufacturer name
        /// </summary>
        public virtual string Name
        {
            get { return _name; }
        }

        public bool ShowOnHomePage
        {
            get { return _shoOnHomePage; }
        }

        public bool Deleted
        {
            get { return _deleted; }
        }

        protected override void Validate()
        {
        }
    }
}
