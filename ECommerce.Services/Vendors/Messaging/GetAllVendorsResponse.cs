using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Vendors.Messaging
{
    public class GetAllVendorsResponse
    {
        public IEnumerable<VendorViewModel> VendorViewModels { get; set; } 
    }
}
