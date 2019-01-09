using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Stores;
using ECommerce.Services.Stores.Messaging;

namespace ECommerce.Services.Stores
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public StoreService(IStoreRepository storeRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _storeRepository = storeRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create Store by User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateStoreResponse CreateStore(CreateStoreRequest request)
        {
            var response = new CreateStoreResponse();
            var store = request.StoreViewModel.ConvertToStoreModel();
            _storeRepository.Add(store);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Get Store by the user that has loged In
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetStoreResponse GetStore(GetStoreRequest request)
        {
            var response = new GetStoreResponse();
            var store = _storeRepository.GetById(request.StoreViewModel.StoreId);
            response.StoreViewModel = store.ConvertToStoreViewModel();
            return response;
        }


        /// <summary>
        /// Returns all store of the system
        /// this methos is used by admin and also Users
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllStoreResponse GetAllStores(GetAllStoreRequest request)
        {
            var response = new GetAllStoreResponse();
            var store = _storeRepository.GetAll();
            response.StoreViewModels = store.ConvertToStoreViewModelList();
            return response;
        }



        /// <summary>
        /// User Could remove the store that has made before
        /// </summary>
        /// <param name="request"></param>
        public RemoveStoreResponse RemoveStore(RemoveStoreRequest request)
        {
            var response = new RemoveStoreResponse();
            var store = _storeRepository.GetById(request.StoreViewModel.StoreId);
            _storeRepository.Remove(store);
            _unitOfWork.Commit();
            return response;

        }

        /// <summary>
        /// Update Store Method
        /// it update's only the store content such as name of Store
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateStoreResponse UpdateStore(UpdateStoreRequest request)
        {
            var response = new UpdateStoreResponse();
            var store = _storeRepository.GetById(request.StoreViewModel.StoreId);
            _storeRepository.SaveOrUpdate(store);
            _unitOfWork.Commit();
            return response;
        }

        /// <summary>
        /// Returns store by contained brands
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllStoresByBrandResponse GetAllStoresByBrand(GetAllStoresByBrandRequest request)
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// Returns all category by category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllStoresByCategoryResponse GetAllStoresByCategory(GetAllStoresByCategoryRequest request)
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// Most Visited Stores of the web site based on User requested time , today , last 3 days , last week etc!
        /// </summary>
        /// <param name="request"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public GetAllMostVisitedStoresResponse GetAllMostVisitedStores(GetAllMostVisitedStoresRequest request, int date)
        {
            var response = new GetAllMostVisitedStoresResponse();
            var store = _storeRepository.GetAllMostVisitedStoresQuery(date);
            response.StoreViewModels = store.ConvertToStoreViewModelList();
            return response;
        }
    }
}
