using System.Collections.Generic;

namespace ECommerce.Services.Stores.Messaging
{
    public class GetAllMostVisitedStoresResponse :BaseResponse
    {
        public IEnumerable<StoreViewModel> StoreViewModels { get; set; } 
    }
}
