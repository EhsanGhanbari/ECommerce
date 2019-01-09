namespace ECommerce.Services.Orders.Messaging
{
    public class GetOrderRequest
    {
        internal  OrderViewModel OrderViewModel { get; private set; }

        public GetOrderRequest(OrderViewModel orderViewModel)
        {
            OrderViewModel = orderViewModel;
        }
    }
}
