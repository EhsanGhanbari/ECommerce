using ECommerce.Services.Managements.Contacts.Messaging;

namespace ECommerce.Services.Managements.Contacts
{
    public interface IContactService
    {
        /// <summary>
        /// Create Contact 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateContactResponse CreateContact(CreateContactRequest request);
        
        /// <summary>
        /// Get Contact by Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetContactResponse GetContact(GetContactRequest request);
        
        /// <summary>
        /// Get All Contact Response
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllContactsResponse GetAllContacts(GetAllContactsRequest request);
        
        
        /// <summary>
        /// Remove Contact 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveContactResponse RemoveContact(RemoveContactRequest request);


        /// <summary>
        /// Create Contact Reply, Persists the reply in database
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateContactReplyResponse CreateContactReply(CreateContactReplyRequest request);

    }
}
