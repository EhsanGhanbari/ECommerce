using System;

namespace ECommerce.Services.Messages
{
    public class MessageViewModel
    {
        public Guid userId { get; set; }
        public Guid MessageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
