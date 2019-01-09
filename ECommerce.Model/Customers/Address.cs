using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Customers
{
    public class Address : ValueObjectBase
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }


        protected override void Validate()
        {
        }
    }
}
