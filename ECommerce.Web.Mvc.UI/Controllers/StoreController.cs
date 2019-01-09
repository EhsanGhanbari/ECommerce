using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Stores;
using ECommerce.Services.Stores.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class StoreController : BaseController
    {
        private readonly IStoreService _storeService;

        public StoreController(ICookieStorageService cookieStorageService, IStoreService storeService)
            : base(cookieStorageService)
        {
            _storeService = storeService;
        }


        /// <summary>
        /// Returns list all stores in the system
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var storeViewModel = new StoreViewModel();
            var request = new GetAllStoreRequest(storeViewModel);
            var stores = _storeService.GetAllStores(request);
            return View(stores);
        }



        /// <summary>
        /// Returns more details about a store
        /// </summary>
        /// <returns></returns>
        public ActionResult More(Guid storeId)
        {
            var storeViewModel = new StoreViewModel();
            var request = new GetStoreRequest(storeViewModel);
            var store = _storeService.GetStore(request);
            return View("More", store);
        }


        /// <summary>
        /// Returns the create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(StoreViewModel storeViewModel)
        {
            var request = new CreateStoreRequest(storeViewModel);

            if (ModelState.IsValid)
            {
                _storeService.CreateStore(request);
            }
            return View("Create");
        }




        /// <summary>
        /// Edit Store Content By Admin
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public ActionResult Edit(Guid storeId)
        {
            var storeViewModel = new StoreViewModel();
            var request = new GetStoreRequest(storeViewModel);
            var store = _storeService.GetStore(request);
            return View("Edit", store.StoreViewModel);
        }

        [HttpPost]
        public ActionResult Edit(StoreViewModel storeViewModel)
        {
            var request = new UpdateStoreRequest(storeViewModel);

            if (ModelState.IsValid)
            {
                _storeService.UpdateStore(request);
            }
            return View("Edit");
        }


        /// <summary>
        /// Remove Store action 
        /// it is done in PooUp Modal 
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Remove(Guid storeId)
        {
            var storeViewModel = new StoreViewModel { StoreId = storeId };
            var request = new RemoveStoreRequest(storeViewModel);
            if (ModelState.IsValid)
            {
                _storeService.RemoveStore(request);
            }
            return View();
        }


        /// <summary>
        /// Store By brands 
        /// </summary>
        /// <returns></returns>
        public ActionResult StoreByBrand(Guid brandId)
        {
            var storeViewModel = new StoreViewModel {BrandId = brandId};
            var request = new GetAllStoresByBrandRequest(storeViewModel);
            var store = _storeService.GetAllStoresByBrand(request);
            return View("",store);
        }


        /// <summary>
        /// Store By Category
        /// </summary>
        /// <returns></returns>
        public ActionResult StoreByCategory(Guid categoryId)
        {
            var storeViewModel = new StoreViewModel { CategoryId = categoryId };
            var request = new GetAllStoresByCategoryRequest(storeViewModel);
            var store = _storeService.GetAllStoresByCategory(request);
            return View();
        }

    }
}
