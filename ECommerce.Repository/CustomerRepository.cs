using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Customers;

namespace ECommerce.Repository
{
    public class CustomerRepository : Repository<Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
