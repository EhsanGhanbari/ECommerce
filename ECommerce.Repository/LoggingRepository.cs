using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Loggings;

namespace ECommerce.Repository
{
    public class LoggingRepository : Repository<Logging, Guid>, ILoggingRepository
    {
        public LoggingRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
