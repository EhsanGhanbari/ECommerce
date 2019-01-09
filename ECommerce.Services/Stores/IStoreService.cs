using ECommerce.Services.Stores.Messaging;

namespace ECommerce.Services.Stores
{
    public interface IStoreService
    {

        /// <summary>
        /// Create Store 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateStoreResponse CreateStore(CreateStoreRequest request);

        /// <summary>
        /// Get Store by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetStoreResponse GetStore(GetStoreRequest request);

        /// <summary>
        /// Get All store
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllStoreResponse GetAllStores(GetAllStoreRequest request);

        /// <summary>
        /// Remove store 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveStoreResponse RemoveStore(RemoveStoreRequest request);

        /// <summary>
        /// Update store
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateStoreResponse UpdateStore(UpdateStoreRequest request);


        /// <summary>
        /// Get All Store by brand 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllStoresByBrandResponse GetAllStoresByBrand(GetAllStoresByBrandRequest request);


        /// <summary>
        /// Get All Store by Category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllStoresByCategoryResponse GetAllStoresByCategory(GetAllStoresByCategoryRequest request);


        /// <summary>
        /// Get All Most Visited Stores
        /// </summary>
        /// <param name="request"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        GetAllMostVisitedStoresResponse GetAllMostVisitedStores(GetAllMostVisitedStoresRequest request, int date);
    }
}
