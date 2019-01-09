using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Messages;
using ECommerce.Services.Messages.Messaging;

namespace ECommerce.Services.Messages
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public MessageService(IMessageRepository messageRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _messageRepository = messageRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create message by user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateMessageResponse CreateMessage(CreateMessageRequest request)
        {
            var response = new CreateMessageResponse();
            var message = request.MessageViewModel.ConvertToMessageModel();
            _messageRepository.Add(message);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// returns all message 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllMessageResponse GetAllMessage(GetAllMessageRequest request)
        {
            var response = new GetAllMessageResponse();
            var messages = _messageRepository.GetAll();
            response.MessageViewModel = messages.ConvertToMessageViewModelList();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetMessageResponse GetMessage(GetMessageRequest request)
        {
            var response = new GetMessageResponse();
            var message = _messageRepository.GetById(request.MessageViewModel.MessageId);
            response.MessageViewModel = message.ConvertToMessageViewModel();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveMessageResponse RemoveMessage(RemoveMessageRequest request)
        {
            var response = new RemoveMessageResponse();
            var message = request.MessageViewModel.ConvertToMessageModel();
            _messageRepository.Remove(message);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Get All Unread messages
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllUnreadMessagesResponse GetAllUnreadMessages(GetAllUnreadMessagesRequest request)
        {
            var response = new GetAllUnreadMessagesResponse();
            var messages = _messageRepository.GetAllUnreadMessagesQuery(request.MessageViewModel.userId);
            response.MessageViewModels = messages.ConvertToMessageViewModelList();
            return response;
        }
    }
}
