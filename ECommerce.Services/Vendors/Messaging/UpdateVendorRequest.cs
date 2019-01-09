using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Vendors.Messaging
{
    public class UpdateVendorRequest
    {
        internal VendorViewModel VendorViewModel { get; private set; }

        public UpdateVendorRequest(VendorViewModel vendorViewModel)
        {
            VendorViewModel = vendorViewModel;
        }
    }
}
