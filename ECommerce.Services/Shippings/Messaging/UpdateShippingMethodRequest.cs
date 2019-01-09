namespace ECommerce.Services.Shippings.Messaging
{
    public class UpdateShippingMethodRequest
    {
        internal ShippingViewModel ShippingViewModel { get; private set; }

        public UpdateShippingMethodRequest(ShippingViewModel shippingViewModel)
        {
            ShippingViewModel = shippingViewModel;
        }
    }
}
