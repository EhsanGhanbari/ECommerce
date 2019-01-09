using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Shippings;

namespace ECommerce.Repository
{
    public class ShippingRepository : Repository<Shipping, Guid>, IShippingRepository
    {
        public ShippingRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
