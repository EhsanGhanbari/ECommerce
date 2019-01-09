namespace ECommerce.Services.Customers.Messaging
{
    public class CreateCustomerRequest
    {
        internal CustomerViewModel CustomerViewModel { get; private set; }

        public CreateCustomerRequest(CustomerViewModel customerViewModel)
        {
            CustomerViewModel = customerViewModel;
        }

    }
}
