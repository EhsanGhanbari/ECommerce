using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Contacts
{
    [Validator(typeof(ContactValidation))]
    public class ContactViewModel
    {
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsRead { get; set; }
        public bool IsReplied { get; set; }
        public string ReplyMessage { get; set; }
        public DateTime ReplyDate { get; set; }
    }
}
