using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Discounts;

namespace ECommerce.Repository
{
    public class DiscountRepository : Repository<Discount, Guid>, IDiscountRepository
    {
        public DiscountRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
