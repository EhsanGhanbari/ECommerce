namespace ECommerce.Services.Baskets.Messaging
{
    public class RemoveBasketItemRequest
    {
        internal BasketViewModel BasketViewModel { get; private set; }

        public RemoveBasketItemRequest(BasketViewModel basketViewModel)
        {
            BasketViewModel = basketViewModel;
        }
    }
}
