using System.Collections.Generic;

namespace ECommerce.Services.Customers.Messaging
{
    public class GetAllCustomerResponse
    {
        public IEnumerable<CustomerViewModel> CustomerViewModels { get; set; }  
    }
}
