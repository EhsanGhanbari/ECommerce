namespace ECommerce.Services.Shippings.Messaging
{
    public class CreateShippingMethodRequest
    {
        internal ShippingViewModel ShippingViewModel { get; private set; }

        public CreateShippingMethodRequest(ShippingViewModel shippingViewModel)
        {
            ShippingViewModel = shippingViewModel;
        }
    }
}
