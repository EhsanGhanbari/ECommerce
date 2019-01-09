namespace ECommerce.Services.Shippings.Messaging
{
    public class GetAllShippingMethodsRequest
    {
        internal ShippingViewModel ShippingViewModel { get; private set; }

        public GetAllShippingMethodsRequest(ShippingViewModel shippingViewModel)
        {
            ShippingViewModel = shippingViewModel;
        }
    }
}
