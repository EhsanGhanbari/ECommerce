using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Customers;

namespace ECommerce.Model.Forums
{
    /// <summary>
    /// Represents a forum subscription item
    /// </summary>
    public class ForumSubscription : EntityBase<Guid>
    {
        /// <summary>
        /// Gets or sets the forum subscription identifier
        /// </summary>
        public virtual Guid SubscriptionGuid { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the forum identifier
        /// </summary>
        public virtual int ForumId { get; set; }

        /// <summary>
        /// Gets or sets the topic identifier
        /// </summary>
        public virtual int TopicId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
