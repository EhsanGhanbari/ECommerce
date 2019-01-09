using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Vendors;

namespace ECommerce.Repository
{
    public class VendorRepository : Repository<Vendor, Guid>
    {
        public VendorRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
