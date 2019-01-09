namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoresByBrandRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public GetAllStoresByBrandRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
