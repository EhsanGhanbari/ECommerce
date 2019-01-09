using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Commons
{
    public class Comment : EntityBase<Guid>
    {

        /// <summary>
        /// Name of the commentor! dude or cheek
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Email of the Guy
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// Comment body
        /// </summary>
        public virtual string Body { get; set; }


        /// <summary>
        /// Creation Time
        /// </summary>
        public virtual DateTime CreationTime { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
