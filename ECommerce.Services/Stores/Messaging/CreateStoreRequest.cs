namespace ECommerce.Services.Stores.Messaging
{
    public class CreateStoreRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public CreateStoreRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
