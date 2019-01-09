using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Messages
{
    public class Message : EntityBase<Guid>, IAggregateRoot
    {
      
        /// <summary>
        /// Message Subject 
        /// </summary>
        public virtual string Subject { get; set; }
        
        /// <summary>
        /// Message text Body 
        /// </summary>
        public virtual string Body { get; set; }

        /// <summary>
        /// Message has been Remove or not
        /// </summary>
        public virtual bool Removed { get; set; }

        /// <summary>
        /// Message has been sent or not 
        /// </summary>
        public virtual bool HasSent { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
