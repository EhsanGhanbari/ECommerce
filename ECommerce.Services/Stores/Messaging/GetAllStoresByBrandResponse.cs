using System.Collections.Generic;

namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllStoresByBrandResponse
    {
        public IEnumerable<StoreViewModel> StoreViewModels { get; set; }
    }
}
