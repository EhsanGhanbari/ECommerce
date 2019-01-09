using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Loggings
{
    public class ActivityLogType: EntityBase<Guid>
    {
        /// <summary>
        /// Gets or sets the system keyword
        /// </summary>
        public string SystemKeyword { get; set; }

        /// <summary>
        /// Gets or sets the display name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity log type is enabled
        /// </summary>
        public bool Enabled { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
