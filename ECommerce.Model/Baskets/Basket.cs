using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Baskets
{
    public class Basket : EntityBase<Guid>, IAggregateRoot
    {
        private IList<BasketItem> _items;


        public virtual DateTime CreationTime { get; set; }


        public Basket()
        {
            _items = new List<BasketItem>();
        }

        public virtual int NumberOfItems
        {
            get { return _items.Sum(i => i.Quantity); }
        }


        protected override void Validate()
        {

        }
    }
}
