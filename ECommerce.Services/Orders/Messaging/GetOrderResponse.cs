namespace ECommerce.Services.Orders.Messaging
{
    public class GetOrderResponse :BaseResponse
    {
        public OrderViewModel OrderViewModel { get; set; }
    }
}
