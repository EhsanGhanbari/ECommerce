using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class CreateContactRequest
    {
        internal ContactViewModel ContactViewModel { get; private set; }

        public CreateContactRequest(ContactViewModel contactViewModel)
        {
            ContactViewModel = contactViewModel;
        }
    }
}
