namespace ECommerce.Services.Orders.Messaging
{
    public class RemoveOrderRequest
    {
        internal OrderViewModel OrderViewModel { get; private set; }

        public RemoveOrderRequest(OrderViewModel orderViewModel)
        {
            OrderViewModel = orderViewModel;
        }
    }
}
