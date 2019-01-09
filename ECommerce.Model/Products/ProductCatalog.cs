using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductCatalog : EntityBase<Guid>
    {

        /// <summary>
        /// Name of the cataglog
        /// </summary>
        public virtual string Name { get; set; }


        /// <summary>
        /// Catalog is deleted
        /// </summary>
        public virtual bool Deleted { get; set; }

        /// <summary>
        /// Collection of products in catalog
        /// </summary>
        public virtual IList<Product> Products { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
