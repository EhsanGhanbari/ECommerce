using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Services.Forums.Posts.Messaging;

namespace ECommerce.Services.Forums.Posts
{
    public class ForumPostService : IForumPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public ForumPostService(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }



        public CreateForumPostResponse CreateForumPost(CreateForumPostRequest request)
        {
            throw new NotImplementedException();
        }

        public GetForumPostResponse GetForumPost(GetForumPostRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveForumPostResponse RemoveForumPost(RemoveForumPostRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateForumPostResponse UpdateForumPost(UpdateForumPostRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
