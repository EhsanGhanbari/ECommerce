using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Discounts
{
    [Validator(typeof(DiscountValidation))]
    public class DiscountViewModel
    {
        public Guid DiscountId { get; set; }
    }
}
