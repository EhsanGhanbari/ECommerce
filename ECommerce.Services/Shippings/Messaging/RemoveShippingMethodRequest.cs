namespace ECommerce.Services.Shippings.Messaging
{
    public class RemoveShippingMethodRequest
    {
        internal ShippingViewModel ShippingViewModel { get; private set; }

        public RemoveShippingMethodRequest(ShippingViewModel shippingViewModel)
        {
            ShippingViewModel = shippingViewModel;
        }

    }
}
