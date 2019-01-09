using System.Collections.Generic;
using ECommerce.Services.Orders;

namespace ECommerce.Services.Customers.Messaging
{
    public class GetCustomerResponse
    {
        public bool CustomerFound { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }
        public IEnumerable<OrderViewModel> Orders { get; set; }
    }
}
