using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Shippings;
using ECommerce.Services.Shippings.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class ShippingController : BaseController
    {
        private readonly IShippingService _shippingService;

        public ShippingController(ICookieStorageService cookieStorageService,IShippingService shippingService) 
            : base(cookieStorageService)
        {
            _shippingService = shippingService;
        }

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// returns all shipping methods in the system 
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var shippingViewModel = new ShippingViewModel();
            var request = new GetAllShippingMethodsRequest(shippingViewModel);
            var shippings = _shippingService.GetAllShippingMethods(request);
            return View("List",shippings.ShippingViewModels);
        }


        /// <summary>
        /// Create a Shipping method by master
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateMethod()
        {
            return View("CreateMethod");
        }

        [HttpPost]
        public ActionResult CreateMethod(ShippingViewModel shippingViewModel)
        {
            var request = new CreateShippingMethodRequest(shippingViewModel); 

            if (ModelState.IsValid)
            {
                _shippingService.CreateShippingMethod(request);
            }
            return View("CreateMethod");
        }



        /// <summary>
        /// Edit Shipping
        /// </summary>
        /// <param name="shippingId"></param>
        /// <returns></returns>
        public ActionResult Edit(Guid shippingId)
        {
            return View("Edit");
        }

        [HttpPost]
        public ActionResult Edit(ShippingViewModel shippingViewModel)
        {
            var request = new UpdateShippingMethodRequest(shippingViewModel);

            if (ModelState.IsValid)
            {
                _shippingService.UpdateShippingMethod(request);
            }
            return View("Edit");
        }


        /// <summary>
        /// Remove
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void Remove(Guid shippingId)
        {
            var shippingViewModel = new ShippingViewModel();
            var request = new RemoveShippingMethodRequest(shippingViewModel);
            if (ModelState.IsValid)
            {
                _shippingService.RemoveShippingMethod(request);
            }
            //return EmptyView();
        }


    }
}
