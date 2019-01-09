using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Orders
{
    public class OrderItem : EntityBase<Guid>
    {
        
        private readonly Product _product;
        private readonly Order _order;
        private readonly int _quantity;
        private readonly decimal _price;
       
        public OrderItem()
        {
        }

        public OrderItem(Product product, Order order, int quantity)
        {
            _product = product;
            _order = order;
            _price = product.Price;
            _quantity = quantity;
        }

        public virtual Product Product
        {
            get { return _product; }
        }

        public virtual int Quantity
        {
            get { return _quantity; }
        }

        public virtual Order Order
        {
            get { return _order; }
        }

        public virtual decimal Price
        {
            get { return _price; }
        }


        public decimal LineTotal()
        {
            return Quantity * Price;
        }

        protected override void Validate()
        {
            if (Order == null)
                AddBrokenRule(OrderItemBusinessRules.OrderRequired);

            if (Product == null)
                AddBrokenRule(OrderItemBusinessRules.ProductRequired);
        }
    }
}
