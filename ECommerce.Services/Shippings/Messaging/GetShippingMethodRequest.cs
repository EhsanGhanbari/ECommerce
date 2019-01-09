namespace ECommerce.Services.Shippings.Messaging
{
    public class GetShippingMethodRequest
    {
        internal ShippingViewModel ShippingViewModel { get; private set; }

        public GetShippingMethodRequest(ShippingViewModel shippingViewModel)
        {
            ShippingViewModel = shippingViewModel;
        }
    }
}
