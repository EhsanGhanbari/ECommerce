using System;
using System.Collections.Generic;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Commons;
using ECommerce.Model.Products;
using ECommerce.Services.Products.Messaging;

namespace ECommerce.Services.Products
{
    public class ProductService : IProductService
    {

        #region Constructor

        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public ProductService(
            IProductRepository productRepository,
            IUnitOfWork unitOfWork,
            ILogger logger)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #endregion

        #region Product

        /// <summary>
        /// Create product
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var response = new CreateProductResponse();

            try
            {
                var productSize = new ProductSize(request.ProductViewModel.ProductSizeViewModel.Name,
                    request.ProductViewModel.ProductSizeViewModel.ShowOnHomePage);

                var productColor = new ProductColor(request.ProductViewModel.ProductColorViewModel.ColorName,
                    request.ProductViewModel.ProductColorViewModel.AllowComment);

                var productBrand = new ProductBrand(request.ProductViewModel.ProductBrandViewModel.BrandName,
                    request.ProductViewModel.ProductBrandViewModel.ShowOhHomePage);

                var productManufacturer =
                    new ProductManufacturer(request.ProductViewModel.ProductManufacturerViewModel.ManufacturerName,
                        request.ProductViewModel.ProductManufacturerViewModel.ShowOnHomePage);

                var productCategory = new ProductCategory(request.ProductCategories);
                var productTag = new ProductTag(request.ProductTags);
                var productPicture = new ProductPicture(request.ProductPictures);


                var product = new Product(request.ProductViewModel.Name,
                                       request.ProductViewModel.Price,
                                       request.ProductViewModel.AllowComment,
                                       productSize,
                                       productColor,
                                       productBrand,
                                       productManufacturer,
                                       productCategory.ProductCategories,
                                       productTag.ProductTags,
                                       productPicture.ProductPictures
                                       );

                _productRepository.Add(product);
                _unitOfWork.Commit();
                response.Success = true;
                response.MessageType = MessageType.Success;
                response.Message = ServiceMessages.GeneralServiceSuccessMessageOnCreation;
                _logger.Log(response.Message);
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// returns the best selling products of the requested date
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBestSellingProductsResponse GetAllBestSellingProducts(GetAllBestSellingProductsRequest request)
        {
            var response = new GetAllBestSellingProductsResponse();
            try
            {
                var products = _productRepository.GetAllBestSellingProductsQuery(request.Year, request.Month, request.Day);
                if (products != null)
                {
                    response.ProductViewModels = products.ConvertToProductViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }

            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }



        /// <summary>
        /// Get products by it's Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetProductResponse GetProduct(GetProductRequest request)
        {
            var response = new GetProductResponse();
            try
            {
                var product = _productRepository.GetById(request.ProductViewModel.ProductId);

                if (product != null)
                {
                    response.ProductViewModel = product.ConvertToProductViewModel();
                    response.Success = false;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }

            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }


        /// <summary>
        /// returns All products all products of Store
        /// returns All products of the system
        /// </summary>
        /// <returns></returns>
        public GetAllProductResponse GetAllProducts(GetAllProductRequest request)
        {
            var response = new GetAllProductResponse();
            try
            {
                //TODO get all products of who!?
                var product = _productRepository.GetAll();
                if (product != null)
                {
                    response.ProductViewModels = product.ConvertToProductViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }


        /// <summary>
        /// Returns the Product by Category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductsByCategoryResponse GetAllProductsByCategory(GetAllProductsByCategoryRequest request)
        {
            var response = new GetAllProductsByCategoryResponse();

            try
            {
                var product = _productRepository.GetAllProductsByCategoryQuery(request.ProductViewModel.Name);
                if (product != null)
                {
                    response.ProductViewModels = product.ConvertToProductViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Returns the Product by Brand
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductsByBrandResponse GetAllProductsByBrand(GetAllProductsByBrandRequest request)
        {
            var response = new GetAllProductsByBrandResponse();
            try
            {
                var products = _productRepository.GetAllProductsByBrandQuery(request.ProductViewModel.Name);
                if (products != null)
                {
                    response.ProductViewModels = products.ConvertToProductViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveProductResponse RemoveProduct(RemoveProductRequest request)
        {
            var response = new RemoveProductResponse();
            try
            {
                var product = _productRepository.GetById(request.ProductViewModel.ProductId);
                _productRepository.Remove(product);
                _unitOfWork.Commit();

            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Update the Product content 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            var response = new UpdateProductResponse();
            var product = request.ProductViewModel.ConvertToProductModel();
            _productRepository.SaveOrUpdate(product);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductsByTagResponse GetAllProductsByTag(GetAllProductsByTagRequest request)
        {
            var response = new GetAllProductsByTagResponse();
            try
            {
                var products = _productRepository.GetAllProductsByTagQuery(request.ProductViewModel.Name);
                if (products != null)
                {
                    response.ProductViewModel = products.ConvertToProductViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }

        #endregion

        #region Product Tag

        /// <summary>
        /// Get All product tags
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductTagResponse GetAllProductTags(GetAllProductTagRequest request)
        {
            var response = new GetAllProductTagResponse();
            try
            {
                var products = _productRepository.GetAllProductTagsQuery();
                if (products != null)
                {
                    response.ProductTagViewModels = products.ConvertToProductTagViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }


            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveProductTagResponse RemoveProductTag(RemoveProductTagRequest request)
        {
            var response = new RemoveProductTagResponse();
            try
            {
                // var requestedPost = _productRepository.(request.BlogTagViewModel.BlogTagName);
                //if (requestedPost != null)
                //{
                //    //var blog = new Blog();
                //    //blog.RemoveBlogTag(requestedPost);
                //    //_blogRepository.Remove(blog);
                //    _unitOfWork.Commit();
                //    response.Success = true;
                //    response.MessageType = MessageType.Success;
                //    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                //    _logger.Log(response.Message);
                //}
                //else
                //{
                //    response.Success = false;
                //    response.MessageType = MessageType.Info;
                //    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                //    _logger.Log(string.Format(response.Message));
                //}
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }

        #endregion

        #region Product Category

        /// <summary>
        /// Get all products categories
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductCategoriesResponse GetAllProductCategories(GetAllProductCategoriesRequest request)
        {
            var response = new GetAllProductCategoriesResponse();

            try
            {
                var products = _productRepository.GetAllProductCategoriesQuery();
                if (products != null)
                {
                    response.ProductCategoryViewModels = products.ConvertToProductCategoryViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }


            return response;
        }

        /// <summary>
        /// Product category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveProductCategoryResponse RemoveProductCategory(RemoveProductCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Product Brands

        /// <summary>
        /// Remove product brand 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveProductBrandResponse RemoveProductBrand(RemoveProductBrandRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all product brands 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllProductBrandsResponse GetAllProductBrands(GetAllProductBrandsRequest request)
        {
            var response = new GetAllProductBrandsResponse();

            try
            {
                var products = _productRepository.GetAllProductBrandsQuery(request.ProductBrandViewModel.BrandName);
                if (products != null)
                {
                    response.ProductBrandViewModels = products.ConvertToProductBrandViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(String.Format(response.Message));
                _logger.Error(exception.Message);
            }


            return response;
        }

        #endregion

        #region ProductComment

        #endregion

    }
}
