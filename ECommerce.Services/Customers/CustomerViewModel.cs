using System;
using System.Collections.Generic;
using FluentValidation.Attributes;

namespace ECommerce.Services.Customers
{
    [Validator(typeof(CustomerValidation))]
    public class CustomerViewModel
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string PhoneNumber { get; set; }
        public string BasketSummary { get; set; }

        public IEnumerable<AddressViewModel> AddressViewModels { get; set; }
    }
}
