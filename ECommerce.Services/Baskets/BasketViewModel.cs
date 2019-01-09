using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Baskets
{

    [Validator(typeof(BasketValidation))]
    public class BasketViewModel
    {
        public Guid BasketId { get; set; }
        public int NumberOfItems { get; set; }
        public string DeliveryCost { get; set; }
        public string ShippingStatus { get; set; }   
        public string DeleveryNumber { get; set; }
    }
}
