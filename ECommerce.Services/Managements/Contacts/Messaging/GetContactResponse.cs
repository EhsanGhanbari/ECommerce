using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class GetContactResponse : BaseResponse
    {
        public ContactViewModel ContactViewModel { get; set; }
    }
}
