using System;
using System.Linq;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Management
{
    public interface IContactRepository : IRepository<Contact, Guid>
    {
        /// <summary>
        /// Returns all unread contacts 
        /// </summary>
        /// <returns></returns>
        IQueryable<Contact> GetAllUnreadContactsQuery();
    }
}
