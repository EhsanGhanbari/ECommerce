using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Vendors.Messaging;

namespace ECommerce.Services.Vendors
{
    public interface IVendorService
    {
        CreateVendorResponse CreateVendor(CreateVendorRequest request);

        GetAllVendorsResponse GetAllVendors(GetAllVendorsRequest request);

        GetVendorResponse GetVendor(GetVendorRequest request);

        RemoveVendorResponse RemoveVendor(RemoveVendorRequest request);

        UpdateVendorResponse UpdateVendor(UpdateVendorRequest request);
    }
}
