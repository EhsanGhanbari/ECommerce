namespace ECommerce.Services.Baskets.Messaging
{
    public class UpdateBasketItemRequest
    {
        internal BasketViewModel BasketViewModel { get; private set; }

        public UpdateBasketItemRequest(BasketViewModel basketViewModel)
        {
            BasketViewModel = basketViewModel;
        }

    }
}
