namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoreRequest
    {
        internal StoreViewModel StoreViewModel { get; set; }

        public GetAllStoreRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }

    }
}
