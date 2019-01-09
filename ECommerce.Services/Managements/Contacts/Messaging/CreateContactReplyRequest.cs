using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class CreateContactReplyRequest
    {
        internal ContactViewModel ContactViewModel { get; set; }

        public CreateContactReplyRequest(ContactViewModel contactViewModel)
        {
            ContactViewModel = contactViewModel;
        }
    }
}
