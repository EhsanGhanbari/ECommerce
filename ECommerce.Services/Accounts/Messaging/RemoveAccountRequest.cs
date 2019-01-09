using System;

namespace ECommerce.Services.Accounts.Messaging
{
    /// <summary>
    /// remove account
    /// only account owner and admin could remove the account
    /// </summary>
    public class RemoveAccountRequest
    {
        public Guid UserId { get; set; }
    }
}
