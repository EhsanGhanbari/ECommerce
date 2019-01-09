using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Commons
{
    public class Tag : ValueObjectBase
    {

        /// <summary>
        /// Tag Name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Remove tha tag logically
        /// </summary>
        public virtual bool IsDeleted { get; set; }
        
        /// <summary>
        /// number of news
        /// </summary>
        public virtual long Count { get; set; }

        /// <summary>
        /// CreationTime
        /// </summary>
        public virtual DateTime CreationTime { get; set; }


        protected override void Validate()
        {
        }
    }
}
