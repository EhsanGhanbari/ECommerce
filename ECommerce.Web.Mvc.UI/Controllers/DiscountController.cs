using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Discounts;
using ECommerce.Services.Products;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class DiscountController : BaseController
    {
        private readonly IDiscountService _discountService;
        private readonly IProductService _productService;

        public DiscountController(ICookieStorageService cookieStorageService,IDiscountService discountService
            ,IProductService productService) 
           
            : base(cookieStorageService)
        {
            _discountService = discountService;
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
