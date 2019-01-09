using System.Collections.Generic;

namespace ECommerce.Services.Orders.Messaging
{
    public class GetAllOrdersResponse :BaseResponse
    {
        public IEnumerable<OrderViewModel> OrderViewModels { get; set; } 
    }
}
