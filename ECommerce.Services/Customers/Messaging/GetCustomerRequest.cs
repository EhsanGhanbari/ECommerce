namespace ECommerce.Services.Customers.Messaging
{
    public class GetCustomerRequest
    {
        internal CustomerViewModel CustomerViewModel { get; private set; }

        public GetCustomerRequest(CustomerViewModel customerViewModel)
        {
            CustomerViewModel = customerViewModel;
        }

    }
}
