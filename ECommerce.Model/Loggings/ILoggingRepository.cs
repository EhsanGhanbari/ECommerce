using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Loggings
{
    public interface ILoggingRepository : IRepository<Logging, Guid>
    {
    }
}
