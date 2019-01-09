namespace ECommerce.Services.Messages.Messaging
{
    public class GetAllMessageRequest
    {
        internal MessageViewModel MessageViewModel { get; private set; }

        public GetAllMessageRequest(MessageViewModel messageViewModel)
        {
            MessageViewModel = messageViewModel;
        }
    }
}
