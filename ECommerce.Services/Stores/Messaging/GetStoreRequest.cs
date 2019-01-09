namespace ECommerce.Services.Stores.Messaging
{
    public class GetStoreRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public GetStoreRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
