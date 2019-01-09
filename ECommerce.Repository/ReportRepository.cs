using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Management;

namespace ECommerce.Repository
{
    public class ReportRepository : Repository<Report, Guid>, IReportRepository
    {
        public ReportRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
