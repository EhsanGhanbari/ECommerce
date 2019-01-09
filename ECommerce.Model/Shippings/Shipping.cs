using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Orders;

namespace ECommerce.Model.Shippings
{
    public class Shipping : EntityBase<Guid> , IAggregateRoot
    {
        private readonly string _code;
        private readonly string _description;
        private readonly Courier _courier;

        public Shipping()
        {
            
        }

        public Shipping(string code, string description, Courier courier)
        {
            _code = code;
            _description = description;
            _courier = courier;
        }

        public virtual string Code
        {
            get { return _code; }
        }

        public virtual string Description
        {
            get { return _description; }
        }

        public virtual Courier Courier
        {
            get { return _courier; }
        }

        public virtual decimal? TotalWeight { get; set; }


        /// <summary>
        /// Gets the order
        /// </summary>
        public virtual Order Order { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
