using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Customers
{
    public interface ICustomerRepository:IRepository<Customer,Guid>
    {
    }
}
