using System.Collections.Generic;
using ECommerce.Services.Contacts;

namespace ECommerce.Services.Managements.Contacts.Messaging
{
    public class GetAllContactsResponse :BaseResponse 
    {
        public IEnumerable<ContactViewModel> ContactViewModels { get; set; }
    }
}