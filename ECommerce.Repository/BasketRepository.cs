using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Baskets;

namespace ECommerce.Repository
{
    public class BasketRepository : Repository<Basket, Guid>, IBasketRepository
    {
        public BasketRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
