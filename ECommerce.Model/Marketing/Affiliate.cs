using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Affiliates
{
    public class Affiliate : EntityBase<Guid>, IAggregateRoot
    {
        
        /// <summary>
        /// indicating whether the entity has been deleted 
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// indicating whether the entity has been deleted 
        /// </summary>
        public virtual bool IsDeleted { get; set; }

        public virtual DateTime CreationTime { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
