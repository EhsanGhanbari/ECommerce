namespace ECommerce.Services.Customers.Messaging
{
    public class GetAllCustomerRequest
    {
        internal CustomerViewModel CustomerViewModels { get; private set; }

        public GetAllCustomerRequest(CustomerViewModel customerViewModels)
        {
            CustomerViewModels = customerViewModels;
        }

    }
}
