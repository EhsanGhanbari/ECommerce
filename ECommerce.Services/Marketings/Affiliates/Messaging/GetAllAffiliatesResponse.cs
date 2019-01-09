using System.Collections.Generic;

namespace ECommerce.Services.Affiliates.Messaging
{
    public class GetAllAffiliatesResponse
    {
        public IEnumerable<AffiliateViewModel> AffiliateViewModels { get; set; } 
    }
}
