using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Contract.Customers;
using ECommerce.Services.Languages;
using ECommerce.Services.Products;
using ECommerce.Services.Products.Messaging;
using ECommerce.Services.Products.VeiwModels;
using ECommerce.Services.Vendors;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class ProductController : BaseController
    {

        #region Constructor

        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IVendorService _vendorService;

        public ProductController(
            ICookieStorageService cookieStorageService,
            IProductService productService,
            ICustomerService customerService,
            IVendorService vendorService)

            : base(cookieStorageService)
        {
            _productService = productService;
            _customerService = customerService;
            _vendorService = vendorService;
        }

        #endregion

        #region Product

        /// <summary>
        /// returns the list of the product
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var productViewModel = new ProductViewModel();
            var request = new GetAllProductRequest(productViewModel);
            var products = _productService.GetAllProducts(request);
            return View("List", products);
        }


        /// <summary>
        /// Create Product action
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            var request = new CreateProductRequest(productViewModel);
            if (ModelState.IsValid)
            {
                _productService.CreateProduct(request);
            }
            return View("Create");
        }



        /// <summary>
        /// Edit Product by Identity 
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Guid productId)
        {
            var productViewModel = new ProductViewModel { ProductId = productId };
            var request = new GetProductRequest(productViewModel);
            var product = _productService.GetProduct(request);
            return View("Edit", product.ProductViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            var request = new UpdateProductRequest(productViewModel);
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(request);
            }
            return View("Edit");
        }


        /// <summary>
        /// Remove a product
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Remove(Guid productId)
        {
            var productViewModel = new ProductViewModel();
            var request = new RemoveProductRequest(productViewModel);
            _productService.RemoveProduct(request);
            return Json("");
        }


        /// <summary>
        /// Best selling products 
        /// </summary>
        /// <returns></returns>
        public ActionResult BestSelling()
        {
            var productViewModel = new ProductViewModel();
            var request = new GetAllBestSellingProductsRequest(productViewModel);
            var products = _productService.GetAllBestSellingProducts(request);
            return View("BestSelling", products.ProductViewModels);
        }

        #endregion

        #region ProductTag

        public ViewResult Tags()
        {
            var productTagViewModel = new ProductTagViewModel();
            var request = new GetAllProductTagRequest(productTagViewModel);
            var tags = _productService.GetAllProductTags(request);
            return View("Tags", tags);
        }

        #endregion

        #region ProductCategory

        public ViewResult Categories()
        {

            var productCategoryViewModel = new ProductCategoryViewModel();
            var request = new GetAllProductCategoriesRequest(productCategoryViewModel);
            var categories = _productService.GetAllProductCategories(request);
            return View("Categories", categories);
        }
        
        #endregion

        #region ProductBrand

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ViewResult Brands()
        {
            var productBrandViewModel = new ProductBrandViewModel();
            var request = new GetAllProductBrandsRequest(productBrandViewModel);
            var brands = _productService.GetAllProductBrands(request);
            return View("Brands", brands);
        }
        #endregion

    }
}
