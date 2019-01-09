using ECommerce.Services.Caching.CacheStorage;
using ECommerce.Services.Stores;

namespace ECommerce.Services.Caching.Implementation
{
    public class CachedStoreService
    {
        private readonly ICacheStorage _cacheStorage;
        private readonly IStoreService _storeService;

        public CachedStoreService(ICacheStorage cacheStorage, IStoreService storeService)
        {
            _cacheStorage = cacheStorage;
            _storeService = storeService;
        }

    }
}
