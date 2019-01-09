using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Groups
{
    public class Group : EntityBase<Guid>, IAggregateRoot
    {
        /// <summary>
        /// Group Name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Members of Group
        /// </summary>
        public virtual int Members { get; set; }


        public virtual DateTime CreationTime { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
