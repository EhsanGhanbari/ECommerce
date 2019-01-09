namespace ECommerce.Services.Messages.Messaging
{
    public class GetAllUnreadMessagesRequest
    {
       internal MessageViewModel MessageViewModel { get; private set; }

        public GetAllUnreadMessagesRequest(MessageViewModel messageViewModel)
        {
            MessageViewModel = messageViewModel;
        }
    }
}
