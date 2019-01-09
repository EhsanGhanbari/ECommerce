using System.Linq;
using System.Text;
using ECommerce.Infrastructure.Domain;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Services.Contract.Customers;
using ECommerce.Services.Customers.Messaging;
using ECommerce.Model.Customers;

namespace ECommerce.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository customerRepository,IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }



        /// <summary>
        /// Create Customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            var response = new CreateCustomerResponse();
            var customer = request.CustomerViewModel.ConvertToCustmerModel();
            _customerRepository.Add(customer);
            _unitOfWork.Commit();
            return response;
        }

        private void ThrowExceptionIfCustomerIsInvalid(Customer customer)
        {
            if (customer.GetBrokenRules().Count() <= 0) return;
            var brokenRules = new StringBuilder();
            brokenRules.AppendLine("There were problems saving the Customer:");
            foreach (BusinessRule businessRule in customer.GetBrokenRules())
            {
                brokenRules.AppendLine(businessRule.Rule);
            }

           // throw new CustomerInvalidException(brokenRules.ToString());
        }


        /// <summary>
        /// Get Customer by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetCustomerResponse GetCustomer(GetCustomerRequest request)
        {
            var response = new GetCustomerResponse();
            var customer = _customerRepository.GetById(request.CustomerViewModel.CustomerId);
            response.CustomerViewModel = customer.ConvertToCustomerViewModel();
            return response;
        }


        /// <summary>
        /// Returns all Customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllCustomerResponse GetAllCustomers(GetAllCustomerRequest request)
        {
            var response = new GetAllCustomerResponse();
            var customer = _customerRepository.GetAll();
            response.CustomerViewModels = customer.ConvertToCustomerViewModelList();
            return response;
        }


        /// <summary>
        /// Remove Customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveCustomerResponse RemoveCustomer(RemoveCustomerRequest request)
        {
            var response = new RemoveCustomerResponse();
            var customer = request.CustomerViewModel.ConvertToCustmerModel();
            _customerRepository.Remove(customer);
            _unitOfWork.Commit();
            return response;
        }
    }
}
