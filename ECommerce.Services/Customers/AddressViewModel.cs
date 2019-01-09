using FluentValidation.Attributes;

namespace ECommerce.Services.Customers
{
    [Validator(typeof(AddressValidation))]
    public class AddressViewModel
    {
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
