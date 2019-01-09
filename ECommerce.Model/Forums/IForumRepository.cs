using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Forums
{
    public interface IForumRepository : IRepository<Forum, Guid>
    {
    }
}
