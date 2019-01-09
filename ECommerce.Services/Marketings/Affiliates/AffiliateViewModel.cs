using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Affiliates
{
    [Validator(typeof(AffiliateValidation))]
    public class AffiliateViewModel
    {
        public Guid AffiliateId { get; set; }
    }
}
