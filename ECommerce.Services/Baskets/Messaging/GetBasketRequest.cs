namespace ECommerce.Services.Baskets.Messaging
{
    public class GetBasketRequest
    {
        internal BasketViewModel BasketViewModel { get; private set; }

        public GetBasketRequest(BasketViewModel basketViewModel)
        {
            BasketViewModel = basketViewModel;
        }
    }
}
