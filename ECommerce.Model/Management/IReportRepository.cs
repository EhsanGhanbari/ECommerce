using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Management
{
    public interface IReportRepository : IRepository<Report, Guid>
    {
    }
}
