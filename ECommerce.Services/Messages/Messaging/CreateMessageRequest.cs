namespace ECommerce.Services.Messages.Messaging
{
    public class CreateMessageRequest
    {
        internal MessageViewModel MessageViewModel { get; private set; }

        public CreateMessageRequest(MessageViewModel messageViewModel)
        {
            MessageViewModel = messageViewModel;
        }
    }
}
