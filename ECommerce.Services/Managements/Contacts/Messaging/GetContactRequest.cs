using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class GetContactRequest
    {
        internal ContactViewModel ContactViewModel { get; private set; }

        public GetContactRequest(ContactViewModel contactViewModel)
        {
            ContactViewModel = contactViewModel;
        }
    }
}
