using System.Collections.Generic;

namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoreResponse
    {
        public IEnumerable<StoreViewModel> StoreViewModels { get; set; } 
    }
}
