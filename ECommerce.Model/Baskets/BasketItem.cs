using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Baskets
{
    public class BasketItem:EntityBase<Guid>
    {
        private readonly Product _product;
        private readonly Basket _basket;
        private  int _quantity;


        public BasketItem()
        {
        }

        public BasketItem(Product product, Basket basket)
        {
            _product = product;
            _basket = basket;
        }


        public virtual Product Product { get { return _product; } }


        public virtual Basket Basket { get { return _basket; } }


        public virtual int Quantity { get { return _quantity; } }


        public void IncreaseItemQtyBy(int quantity)
        {
            _quantity += quantity;
        }
         

        protected override void Validate()
        {
            if (Product == null)
                AddBrokenRule(BasketItemBusinessRules.ProductRequired);

            if (Basket == null)
                AddBrokenRule(BasketItemBusinessRules.BasketRequired);
        }
    }
}
