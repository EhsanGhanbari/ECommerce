using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Contract.Customers;
using ECommerce.Services.Customers;
using ECommerce.Services.Customers.Messaging;
using ECommerce.Services.Stores;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customerService;
        private readonly IStoreService _storeService;

        public CustomerController(ICookieStorageService cookieStorageService, ICustomerService customerService
            , IStoreService storeService)

            : base(cookieStorageService)
        {
            _customerService = customerService;
            _storeService = storeService;
        }


        /// <summary>
        /// list of all customers
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var customerViewModel = new CustomerViewModel();
            var request = new GetAllCustomerRequest(customerViewModel);
            var customers = _customerService.GetAllCustomers(request);
            return View(customers);
        }





    }
}
