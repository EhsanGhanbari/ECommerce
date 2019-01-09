using System.Collections.Generic;

namespace ECommerce.Services.Baskets.Messaging
{
    public class GetAllBasketItemsResponse : BaseResponse
    {
        public IEnumerable<BasketViewModel> BasketViewModel { get; set; }
    }
}
