using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Forums;

namespace ECommerce.Repository
{
    public class ForumRepository : Repository<Forum, Guid>, IForumRepository
    {
        public ForumRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
