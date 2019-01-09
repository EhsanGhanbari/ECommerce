using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Messages
{
    public interface IMessageRepository : IRepository<Message, Guid>
    {
        /// <summary>
        /// Returns all unread messages of a user 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IEnumerable<Message> GetAllUnreadMessagesQuery(Guid userId);
    }
}
