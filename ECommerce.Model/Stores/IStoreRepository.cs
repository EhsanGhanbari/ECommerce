using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Stores
{
    public interface IStoreRepository : IRepository<Store, Guid>
    {
        /// <summary>
        /// returns the most visited store based on sate amount
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        IEnumerable<Store> GetAllMostVisitedStoresQuery(int date);
    }
}
