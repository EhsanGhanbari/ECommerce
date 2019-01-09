using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Taxes;

namespace ECommerce.Repository
{
    public class TaxRepository : Repository<Tax, Guid>
    {
        public TaxRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
