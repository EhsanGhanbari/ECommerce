using System;
using ECommerce.Model.Customers;

namespace ECommerce.Services.Accounts
{
    public class AuthenticationService : IAuthenticationService
    {

        public void SignIn(Customer customer, bool createPersistentCookie)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public Customer GetAuthenticatedCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
