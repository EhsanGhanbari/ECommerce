using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Accounts;

namespace ECommerce.Repository
{
    public class AccountRepository : Repository<Account, Guid>, IAccountRepository
    {
        public AccountRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
