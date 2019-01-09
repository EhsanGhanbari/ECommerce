using System;

namespace ECommerce.Services.Accounts.Messaging
{
    public class ChangePasswordRequest
    {
        public Guid UserId { get; set; }
    }
}
