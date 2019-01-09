using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Forums
{
    /// <summary>
    /// Represents a forum group
    /// </summary>
    public class ForumGroup : EntityBase<Guid>
    {

        private ICollection<Forum> _forums;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public virtual int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public virtual DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the collection of Forums
        /// </summary>
        public virtual ICollection<Forum> Forums
        {
            get { return _forums ?? (_forums = new List<Forum>()); }
            protected set { _forums = value; }
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
