using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    /// <summary>
    /// Determines which user requesting to get the contact
    /// </summary>
    public class GetAllContactsRequest
    {
        internal ContactViewModel ContactViewModel { get;  private set; }

        public GetAllContactsRequest(ContactViewModel contactViewModel)
        {
            ContactViewModel = contactViewModel;
        }

    }
}
