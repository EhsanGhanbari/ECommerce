using System;
using System.Collections.Generic;
using ECommerce.Model.Products;
using ECommerce.Services.Caching.CacheStorage;
using ECommerce.Services.Products.Messaging;

namespace ECommerce.Services.Caching.Implementation
{
    public class CachedProductService //:IProductService
    {
        private readonly ICacheStorage _cacheStorage;
        private readonly IProductRepository _productRepository;
        private readonly Object _getTopSellingProductsLock = new Object();
        private readonly Object _getAllProductsLock = new Object();



        public CachedProductService(ICacheStorage cacheStorage,IProductRepository productRepository)
        {
            _cacheStorage = cacheStorage;
            _productRepository = productRepository;
        }


        public GetProductResponse GetProduct(GetProductRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns All the Cached Product
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductResponse GetAllProducts(GetAllProductRequest request)
        {
            var response = new GetAllProductResponse();
            lock (_getAllProductsLock)
            {
                var allProducts = _cacheStorage.Retrieve<IEnumerable<Product>>(CacheKeys.AllProducts.ToString());

                if (allProducts == null)
                {
                    allProducts = _productRepository.GetAll();
                    _cacheStorage.Store(CacheKeys.AllProducts.ToString(), allProducts);
                }
                //ToDO it is not completed yet 
                return response;
            }
        }



        public GetAllProductsByCategoryResponse GetAllProductsByCategory(GetAllProductsByCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveProductResponse RemoveProduct(RemoveProductRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }


        public GetProductResponse GetProductBy(GetProductRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            throw new NotImplementedException();
        }
    }
}
