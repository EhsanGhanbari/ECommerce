using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Shippings;
using ECommerce.Services.Shippings.Messaging;

namespace ECommerce.Services.Shippings
{
    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public ShippingService(IShippingRepository shippingRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _shippingRepository = shippingRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create Shippment Method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateShippingMethodResponse CreateShippingMethod(CreateShippingMethodRequest request)
        {
            var response = new CreateShippingMethodResponse();
            var shipping = request.ShippingViewModel.ConverToShippingModel();
            _shippingRepository.Add(shipping);
            _unitOfWork.Commit();
            return response;
        }

        /// <summary>
        /// Get All Shipment Methods
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllShippingMethodsResponse GetAllShippingMethods(GetAllShippingMethodsRequest request)
        {
            var response = new GetAllShippingMethodsResponse();
            var shippings = _shippingRepository.GetAll();
            response.ShippingViewModels = shippings.ConvertToShippingViewModelList();
            return response;
        }


        /// <summary>
        /// Get Shipping method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetShippingMethodResponse GetShippingMethod(GetShippingMethodRequest request)
        {
            var response = new GetShippingMethodResponse();
            var shipping = _shippingRepository.GetById(request.ShippingViewModel.ShippingId);
            response.ShippingViewModel = shipping.ConvertToShippingViewModel();
            return response;
        }


        /// <summary>
        /// Remove Shpping method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveShippingMethodResponse RemoveShippingMethod(RemoveShippingMethodRequest request)
        {
            var response = new RemoveShippingMethodResponse();
            var shippingViewModel = new ShippingViewModel { ShippingId = request.ShippingViewModel.ShippingId };
            var shipping = shippingViewModel.ConverToShippingModel();
            _shippingRepository.Remove(shipping);
            return response;
        }


        /// <summary>
        /// Update Shipping method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateShippingMethodResponse UpdateShippingMethod(UpdateShippingMethodRequest request)
        {
            var response = new UpdateShippingMethodResponse();
            var shippingViewModel = request.ShippingViewModel;
            var shipping = shippingViewModel.ConverToShippingModel();
            _shippingRepository.SaveOrUpdate(shipping);
            return response;
        }
    }
}
