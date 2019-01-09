namespace ECommerce.Services.Messages.Messaging
{
    public class RemoveMessageRequest
    {
        internal MessageViewModel MessageViewModel { get; private set; }
        
        public RemoveMessageRequest(MessageViewModel messageViewModel)
        {
            MessageViewModel = messageViewModel;
        }
    }
}
