using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Taxes
{
    public interface ITaxRepository : IRepository<Tax, Guid>
    {
    }
}
