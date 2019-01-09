using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Vendors.Messaging
{
    public class CreateVendorRequest
    {
        internal VendorViewModel VendorViewModel { get; private set; }

        public CreateVendorRequest(VendorViewModel vendorViewModel)
        {
            VendorViewModel = vendorViewModel;
        }
    }
}
