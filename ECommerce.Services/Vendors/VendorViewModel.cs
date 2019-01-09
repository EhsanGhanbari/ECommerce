using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Vendors
{
    [Validator(typeof(VendorValidation))]
    public class VendorViewModel
    {
        public Guid VendorId { get; set; }


    }
}
