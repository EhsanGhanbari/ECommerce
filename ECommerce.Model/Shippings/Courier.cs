using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Shippings
{
    public class Courier : EntityBase<Guid>
    {
        private readonly string _name;
        private readonly IEnumerable<Shipping> _services;


        public Courier()
        {
        }

        public Courier(string name, IEnumerable<Shipping> services)
        {
            _name = name;
            _services = services;
        }

        public virtual string Name
        {
            get { return _name; }
        }

        public virtual IEnumerable<Shipping> Services
        {
            get { return _services; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
