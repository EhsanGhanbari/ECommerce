using ECommerce.Model.Products;

namespace ECommerce.Model.Baskets
{
    public static class BasketItemFactory
    {
        public static BasketItem CreateItemFor(Product product, Basket basket)
        {
            return new BasketItem(product, basket);
        }
    }
}
