namespace ECommerce.Services.Orders.Messaging
{
    public class GetAllOrdersRequest
    {
        internal OrderViewModel OrderViewModel { get; private set; }

        public GetAllOrdersRequest(OrderViewModel orderViewModel)
        {
            OrderViewModel = orderViewModel;
        }
    }
}
