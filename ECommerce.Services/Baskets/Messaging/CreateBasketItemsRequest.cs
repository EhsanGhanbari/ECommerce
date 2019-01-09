using System.Collections.Generic;

namespace ECommerce.Services.Baskets.Messaging
{
    public class CreateBasketItemsRequest
    {
        internal IList<BasketViewModel> ProductsToAddtoBasket { get; private set; }

        public CreateBasketItemsRequest()
        {
            ProductsToAddtoBasket = new List<BasketViewModel>();
        }
    }
}
