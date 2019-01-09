namespace ECommerce.Services.Messages.Messaging
{
    public class GetMessageRequest
    {
        internal MessageViewModel MessageViewModel { get; private set; }

        public GetMessageRequest(MessageViewModel messageViewModel)
        {
            MessageViewModel = messageViewModel;
        }
    }
}
