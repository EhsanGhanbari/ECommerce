using System.Collections.Generic;

namespace ECommerce.Services.Messages.Messaging
{
    public class GetAllMessageResponse
    {
        public IEnumerable<MessageViewModel> MessageViewModel { get; set; }
    }
}
