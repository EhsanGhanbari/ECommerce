using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Baskets;
using ECommerce.Services.Products;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class BasketController : BaseController
    {

        private readonly IBasketService _basketService;
        private readonly IProductService _productService;

        public BasketController(
            ICookieStorageService cookieStorageService,
            IBasketService basketService,
            IProductService productService)

            : base(cookieStorageService)
        {
            _basketService = basketService;
            _productService = productService;
        }


        /// <summary>
        /// List of all items in the basket
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }



        /// <summary>
        /// Add an item to the basket
        /// </summary>
        /// <returns></returns>
        public ActionResult AddItem()
        {
            return View();
        }
        

        /// <summary>
        /// Remove an item from basket
        /// </summary>
        /// <returns></returns>
        public ActionResult RemoveItem()
        {
            return View();
        }

        
        /// <summary>
        /// Remove all of the existing items from basket
        /// </summary>
        /// <returns></returns>
        public ActionResult RemoveAllItems()
        {
            return View();
        }


    }
}
