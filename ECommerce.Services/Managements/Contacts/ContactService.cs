using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Management;
using ECommerce.Services.Managements.Contacts.Messaging;

namespace ECommerce.Services.Managements.Contacts
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Cearet contact by every body to the web site admin 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateContactResponse CreateContact(CreateContactRequest request)
        {
            var response = new CreateContactResponse();
            var contact = request.ContactViewModel.ConvertToContactModel();
            try
            {
                _contactRepository.Add(contact);
                _unitOfWork.Commit();
                response.Success = true;
                response.MessageType = MessageType.Success;
                response.Message = ServiceMessages.GeneralServiceSuccessMessageOnCreation;
                _logger.Log(response.Message);
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.UnSuccess;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Returns All of the contact
        /// </summary>
        /// <returns></returns>
        public GetAllContactsResponse GetAllContacts(GetAllContactsRequest request)
        {
            var response = new GetAllContactsResponse();
            try
            {
                var contacts = _contactRepository.GetAll();
                if (contacts != null)
                {
                    response.ContactViewModels = contacts.ConvertToContactViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                _logger.Log(string.Format(ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Returns a contact by ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetContactResponse GetContact(GetContactRequest request)
        {
            var response = new GetContactResponse();
            try
            {
                var contact = _contactRepository.GetById(request.ContactViewModel.ContactId);
                if (contact != null)
                {
                    response.ContactViewModel = contact.ConvertToContactViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(String.Format(response.Message));
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                _logger.Log(string.Format(ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation));
                _logger.Error(exception.Message);
            }
            return response;
        }



        /// <summary>
        /// Removes the selected contact by Id
        /// </summary>
        /// <param name="request"></param>
        public RemoveContactResponse RemoveContact(RemoveContactRequest request)
        {
            var response = new RemoveContactResponse();
            try
            {
                var contact = _contactRepository.GetById(request.ContactViewModel.ContactId);
                if (contact != null)
                {
                    _contactRepository.Remove(contact);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Warning;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }

            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                _logger.Error(exception.Message);
            }
            return response;
        }




        /// <summary>
        /// Creates the reply in database 
        /// marks the message as read
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateContactReplyResponse CreateContactReply(CreateContactReplyRequest request)
        {
            var response = new CreateContactReplyResponse();
            try
            {
                var contact = request.ContactViewModel.ConvertToContactModel();
                contact.IsRead = true;
                //TODO send the message
                _contactRepository.SaveOrUpdate(contact);
                _unitOfWork.Commit();
                response.Success = true;
                response.MessageType = MessageType.Success;
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.UnSuccess;
                _logger.Error(exception.Message);
            }
            return response;
        }
    }
}
