using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Stores
{
    public class Store : EntityBase<Guid>, IAggregateRoot
    {

        /// <summary>
        /// Store Name
        /// Every user could has several store in his/her account
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<Product> Products { get; set; }


        /// <summary>
        /// Url Name of the Store
        /// </summary>
        public string UrlName { get; set; }


        public Store()
        {
        }

        public Store(Product product)
        {
            Products = (IList<Product>)product;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        protected override void Validate()
        {
            if (Name == null)
            {
                AddBrokenRule(StoreBusinessRule.NameRequired);
            }
        }
    }
}
