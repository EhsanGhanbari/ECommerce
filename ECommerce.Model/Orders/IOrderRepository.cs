using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Orders
{
    public interface IOrderRepository :IRepository<Order,Guid>
    {
    }
}
