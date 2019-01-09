using System;

namespace ECommerce.Services.Accounts.Messaging
{
    public class GetAllAccountRequest
    {
        //this only could be requested by admin
        public Guid UserId { get; set; }
    }
}
