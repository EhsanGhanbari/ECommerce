using System.Collections.Generic;

namespace ECommerce.Services.Discounts.Messaging
{
    public class GetAllDiscountResponse : BaseResponse
    {
        public IEnumerable<DiscountViewModel> DiscountViewModels { get; set; } 
    }
}
