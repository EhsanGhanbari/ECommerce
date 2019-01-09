using ECommerce.Services.Customers.Messaging;

namespace ECommerce.Services.Contract.Customers
{
    public interface ICustomerService
    {

        /// <summary>
        /// Create Custumer 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateCustomerResponse CreateCustomer(CreateCustomerRequest request);
       
        /// <summary>
        /// return the customer info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetCustomerResponse GetCustomer(GetCustomerRequest request);


        /// <summary>
        /// Returns all customer
        /// it is available for each store
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllCustomerResponse GetAllCustomers(GetAllCustomerRequest request);


        /// <summary>
        /// Removes the customer from list 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveCustomerResponse RemoveCustomer(RemoveCustomerRequest request);

    }

}
