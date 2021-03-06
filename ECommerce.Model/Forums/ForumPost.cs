﻿using System;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Customers;

namespace ECommerce.Model.Forums
{
    /// <summary>
    /// Represents a forum post
    /// </summary>
    public class ForumPost : EntityBase<Guid>
    {
        /// <summary>
        /// Gets or sets the forum topic identifier
        /// </summary>
        public virtual int TopicId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public virtual int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the text
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Gets or sets the IP address
        /// </summary>
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public virtual DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets the topic
        /// </summary>
        public virtual ForumTopic ForumTopic { get; set; }

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
