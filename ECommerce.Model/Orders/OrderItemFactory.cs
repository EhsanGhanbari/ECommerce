using ECommerce.Model.Products;

namespace ECommerce.Model.Orders
{
    public static class OrderItemFactory
    {
        public static OrderItem CreateItemFor(Product product, Order order, int quantity)
        {
            return new OrderItem(product, order, quantity);
        }
    }
}
