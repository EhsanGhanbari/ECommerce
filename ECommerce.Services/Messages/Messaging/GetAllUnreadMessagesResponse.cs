using System.Collections.Generic;

namespace ECommerce.Services.Messages.Messaging
{
    public class GetAllUnreadMessagesResponse :BaseResponse 
    {
        public IEnumerable<MessageViewModel> MessageViewModels { get; set; } 
    }
}
