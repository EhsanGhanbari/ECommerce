using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Orders;

namespace ECommerce.Model.Discounts
{
    /// <summary>
    /// Represents a discount usage history entry
    /// </summary>
    public  class DiscountUsageHistory : EntityBase<Guid>
    {
        /// <summary>
        /// Gets or sets the discount identifier
        /// </summary>
        public virtual int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public virtual int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; set; }


        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public virtual Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets the order
        /// </summary>
        public virtual Order Order { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
