using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Customers
{
    public class Customer : EntityBase<Guid>, IAggregateRoot
    {

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Mobile { get; set; }
        public virtual DateTime CreationTime { get; set; }

        public virtual string PhoneNumber { get; set; }
        private IList<Address> _addresses = new List<Address>();


        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }




        protected override void Validate()
        {
            if (String.IsNullOrEmpty(FirstName))
                AddBrokenRule(CustomerBusinessRules.FirstNameRequired);
            if (String.IsNullOrEmpty(LastName))
                AddBrokenRule(CustomerBusinessRules.SecondNameRequired);

        }
    }
}
