using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Stores;

namespace ECommerce.Repository
{
    public class StoreRepository : Repository<Store, Guid>, IStoreRepository
    {
        public StoreRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// Most Visited Store
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public IEnumerable<Store> GetAllMostVisitedStoresQuery(int date)
        {
            throw new NotImplementedException();
        }
    }
}
