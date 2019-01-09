namespace ECommerce.Services.Orders.Messaging
{
    public class UpdateOrderRequest
    {
        internal OrderViewModel OrderViewModel { get; private set; }

        public UpdateOrderRequest(OrderViewModel orderViewModel)
        {
            OrderViewModel = orderViewModel;
        }
    }
}
