namespace ECommerce.Services.Orders.Messaging
{
    public class CreateOrderRequest
    {
        internal OrderViewModel OrderViewModel { get; private set; }

        public CreateOrderRequest(OrderViewModel orderViewModel)
        {
            OrderViewModel = orderViewModel;
        }
    }
}
