namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoresByCategoryRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public GetAllStoresByCategoryRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
