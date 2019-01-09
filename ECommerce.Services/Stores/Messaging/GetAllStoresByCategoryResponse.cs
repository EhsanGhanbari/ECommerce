using System.Collections.Generic;

namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoresByCategoryResponse
    {
        public IEnumerable<StoreViewModel> StoreViewModels { get; private set; } 
    }
}
