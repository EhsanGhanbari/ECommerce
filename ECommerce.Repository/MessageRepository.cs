using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Messages;

namespace ECommerce.Repository
{
    public class MessageRepository : Repository<Message, Guid>, IMessageRepository
    {
        public MessageRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }


        /// <summary>
        /// returns all unread message of a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<Message> GetAllUnreadMessagesQuery(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
