using System.Collections.Generic;

namespace ECommerce.Services.Shippings.Messaging
{
    public class GetAllShippingMethodsResponse
    {
        public IEnumerable<ShippingViewModel> ShippingViewModels { get; set; } 
    }
}
