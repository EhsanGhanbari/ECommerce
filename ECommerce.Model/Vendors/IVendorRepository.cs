using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Vendors
{
    public interface IVendorRepository :IRepository<Vendor,Guid>
    {

    }
}
