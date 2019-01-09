namespace ECommerce.Services.Baskets.Messaging
{
    public class GetAllBasketItemsRequest
    {
        internal BasketViewModel BasketViewModel { get; private set; }

        public GetAllBasketItemsRequest(BasketViewModel basketViewModel)
        {
            BasketViewModel = basketViewModel;
        }
    }
}
