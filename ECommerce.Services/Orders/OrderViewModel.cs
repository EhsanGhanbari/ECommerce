using System;
using ECommerce.Services.Baskets;
using ECommerce.Services.Customers;
using FluentValidation.Attributes;

namespace ECommerce.Services.Orders
{
    [Validator(typeof(OrderValidation))]
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public CustomerViewModel Customer { get; set; }
        public BasketViewModel Basket { get; set; }
        public AddressViewModel Address { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMerchant { get; set; }
        public string PaymentToken { get; set; }
    }
}
