using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Discounts
{
    public interface IDiscountRepository : IRepository<Discount, Guid>
    {

    }
}
