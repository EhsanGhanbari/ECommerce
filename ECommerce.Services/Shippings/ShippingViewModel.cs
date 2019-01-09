using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Attributes;

namespace ECommerce.Services.Shippings
{
    [Validator(typeof(ShippingViewModel))]
    public class ShippingViewModel
    {
        public Guid ShippingId { get; set; }
    }
}
