using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Baskets
{
    public interface IBasketRepository : IRepository<Basket, Guid>
    {
    }
}
