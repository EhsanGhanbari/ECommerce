namespace ECommerce.Services.Customers.Messaging
{
    public class RemoveCustomerRequest
    {
        internal CustomerViewModel CustomerViewModel { get; set; }

        public RemoveCustomerRequest(CustomerViewModel customerViewModel)
        {
            CustomerViewModel = customerViewModel;
        }

    }
}
