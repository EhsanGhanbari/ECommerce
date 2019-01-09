namespace ECommerce.Services.Orders.Messaging
{
    public class CreateOrderResponse :BaseResponse 
    {
        public OrderViewModel OrderViewModel { get; set; }

    }
}
