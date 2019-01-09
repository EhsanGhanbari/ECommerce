using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Management
{

    /// <summary>
    /// Contacts Made by Users
    /// </summary>
    public class Contact : EntityBase<Guid>, IAggregateRoot 
    {

        /// <summary>
        /// Name of the user
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Email address of user
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// Contact Title
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Contact Body
        /// </summary>
        public virtual string Body { get; set; }


        /// <summary>
        /// if contact is read by admin or not
        /// </summary>
        public virtual bool IsRead { get; set; }

        /// <summary>
        /// if contact is Replyed by admin or not
        /// </summary>
        public virtual bool IsReplied { get; set; }

        /// <summary>
        /// Reply Message made by admin
        /// </summary>
        public virtual string ReplyMessage { get; set; }

        /// <summary>
        /// Reply message date 
        /// </summary>
        public virtual DateTime ReplyDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        
        
        protected override void Validate()
        {
            if (Email == null)
                AddBrokenRule(ContactBusinessRule.EmailRequired);

            if (Title == null)
                AddBrokenRule(ContactBusinessRule.MessageTitleRequired);

            if (Body == null)
                AddBrokenRule(ContactBusinessRule.MessageBodyRequired);

        }
    }
}
