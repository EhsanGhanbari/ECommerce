namespace ECommerce.Services.Stores.Messaging
{
    public class UpdateStoreRequest
    {
        public StoreViewModel StoreViewModel { get; private set; }

        public UpdateStoreRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
