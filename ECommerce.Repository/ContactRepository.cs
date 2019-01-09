using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Management;
using ECommerce.Repository.SessionStorage;

namespace ECommerce.Repository
{
    public class ContactRepository : Repository<Contact, Guid>, IContactRepository
    {
        public ContactRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        /// <summary>
        /// returns all UnReadContacts of the system
        /// </summary>
        /// <returns></returns>
        public IQueryable<Contact> GetAllUnreadContactsQuery()
        {
            //I know it is Wrong!
            var contacts = SessionFactory.GetCurrentSession().QueryOver<Contact>()
                .Where(c=>c.IsRead).List();
            IQueryable<Contact> query = contacts.AsQueryable();

            var result = from c in query
                         where c.IsRead
                         orderby c.CreationTime
                         select c;
            return result;
        }
    }
}
