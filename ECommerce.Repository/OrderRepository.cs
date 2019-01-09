using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Orders;

namespace ECommerce.Repository
{
    public class OrderRepository : Repository<Order, Guid>, IOrderRepository
    {
        public OrderRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
