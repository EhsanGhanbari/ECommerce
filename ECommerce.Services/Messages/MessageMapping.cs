using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Messages;

namespace ECommerce.Services.Messages
{
    public static class MessageMapper
    {

        /// <summary>
        /// Convert Message to MessageViewModel
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageViewModel ConvertToMessageViewModel(this Message message)
        {
            Mapper.CreateMap<Message, MessageViewModel>()
                  .ForMember(mes => mes.MessageId, me => me.MapFrom(m => m.Id));
            return Mapper.Map<Message, MessageViewModel>(message);
        }


        /// <summary>
        /// Convert to Message Model
        /// </summary>
        /// <param name="messageViewModel"></param>
        /// <returns></returns>
        public static Message ConvertToMessageModel(this MessageViewModel messageViewModel)
        {
            return Mapper.Map<MessageViewModel, Message>(messageViewModel);
        }



        /// <summary>
        /// Convert to Message View Model list 
        /// </summary>
        /// <param name="messages"></param>
        /// <returns></returns>
        public static IEnumerable<MessageViewModel> ConvertToMessageViewModelList(this IEnumerable<Message> messages)
        {
            Mapper.CreateMap<Message, MessageViewModel>()
                  .ForMember(mes => mes.MessageId, me => me.MapFrom(m => m.Id));
            return Mapper.Map<IEnumerable<Message>, IEnumerable<MessageViewModel>>(messages);
        }
    }
}
