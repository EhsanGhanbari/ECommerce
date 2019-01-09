namespace ECommerce.Services.Orders.Messaging
{
    public class UpdateOrderResponse:BaseResponse
    {
        public OrderViewModel OrderViewModel { get; set; }
    }
}
