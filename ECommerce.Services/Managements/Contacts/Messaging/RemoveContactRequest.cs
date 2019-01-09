using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class RemoveContactRequest
    {
        internal ContactViewModel ContactViewModel { get; private set; }

        public RemoveContactRequest(ContactViewModel contactViewModel)
        {
            ContactViewModel = contactViewModel;
        }
    }
}
