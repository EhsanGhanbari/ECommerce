namespace ECommerce.Services.Stores.Messaging
{
    public class RemoveStoreRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public RemoveStoreRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }

    }
}
