using ECommerce.Services.Messages.Messaging;

namespace ECommerce.Services.Messages
{
    public interface IMessageService
    {
        /// <summary>
        /// Create Messge 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateMessageResponse CreateMessage(CreateMessageRequest request);

        /// <summary>
        /// Returns all message 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllMessageResponse GetAllMessage(GetAllMessageRequest request);
        
        
        /// <summary>
        /// Returns a message by Id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetMessageResponse GetMessage(GetMessageRequest request);


        /// <summary>
        /// Removes a message By Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveMessageResponse RemoveMessage(RemoveMessageRequest request);


        /// <summary>
        /// Get All Ubread Messages
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllUnreadMessagesResponse GetAllUnreadMessages(GetAllUnreadMessagesRequest request);
    }
}
