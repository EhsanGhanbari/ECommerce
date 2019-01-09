namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllMostVisitedStoresRequest
    {
        internal StoreViewModel StoreViewModel { get; private set; }

        public GetAllMostVisitedStoresRequest(StoreViewModel storeViewModel)
        {
            StoreViewModel = storeViewModel;
        }
    }
}
