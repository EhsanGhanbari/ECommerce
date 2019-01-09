using ECommerce.Model.Customers;

namespace ECommerce.Services.Accounts
{
    /// <summary>
    /// Authentication service interface
    /// </summary>
    public  interface IAuthenticationService
    {
        void SignIn(Customer customer, bool createPersistentCookie);
        void SignOut();
        Customer GetAuthenticatedCustomer();
    }
}
