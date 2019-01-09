using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Baskets;
using ECommerce.Model.Products;
using ECommerce.Services.Baskets.Messaging;

namespace ECommerce.Services.Baskets
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public BasketService(IBasketRepository basketRepository, IProductRepository productRepository,
            IUnitOfWork unitOfWork,ILogger logger)
        {
            _basketRepository = basketRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Creating basket for customer 
        /// add products to basket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateBasketItemsResponse CreateBasketItems(CreateBasketItemsRequest request)
        {
            var response = new CreateBasketItemsResponse();

           
            return response;
        }


        /// <summary>
        /// Get Basket Item Details 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetBasketResponse GetBasketItem(GetBasketRequest request)
        {
            var response = new GetBasketResponse();
            var basket = _basketRepository.GetById(request.BasketViewModel.BasketId);
            response.BasketViewModel = basket.ConvertToBasketViewModel();
            return response;
        }


        /// <summary>
        /// returns the basket items of a customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllBasketItemsResponse GetAllBasketItems(GetAllBasketItemsRequest request)
        {
            var response = new GetAllBasketItemsResponse();
            var basket = _basketRepository.GetAll();
            response.BasketViewModel = basket.ConvertToBasketViewModelList();
            return response;
        }




        /// <summary>
        /// Remove Items from basket 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveBasketItemResponse RemoveBasketItems(RemoveBasketItemRequest request)
        {
            var response = new RemoveBasketItemResponse();
            var basket = request.BasketViewModel.ConvertToBasketModel();
            _basketRepository.Remove(basket);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Update basket Items 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateBasketItemResponse UpdateBasketItems(UpdateBasketItemRequest request)
        {
            var response = new UpdateBasketItemResponse();
            var basket = request.BasketViewModel.ConvertToBasketModel();
            _basketRepository.SaveOrUpdate(basket);
            return response;
        }
    }
}

