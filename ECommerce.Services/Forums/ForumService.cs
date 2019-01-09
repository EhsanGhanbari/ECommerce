using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Forums;
using ECommerce.Services.Forums.Messaging;

namespace ECommerce.Services.Forums
{
    public class ForumService : IForumService
    {
        private readonly IForumRepository _forumRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public ForumService(IForumRepository forumRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _forumRepository = forumRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create forum 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateForumResponse CreateForum(CreateForumRequest request)
        {
            var response = new CreateForumResponse();
            var forum = request.ForumViewModel.ConvertToForumModel();
            _forumRepository.Add(forum);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Remove Forum 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveForumResponse RemoveForum(RemoveForumRequest request)
        {
            var response = new RemoveForumResponse();
            var forum = request.ForumViewModel.ConvertToForumModel();
            _forumRepository.Remove(forum);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Update Forum
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateForumResponse UpdateForum(UpdateForumRequest request)
        {
            var response = new UpdateForumResponse();
            var forum = request.ForumViewModel.ConvertToForumModel();
            _forumRepository.SaveOrUpdate(forum);
            _unitOfWork.Commit();
            return response;
        }
    }
}
