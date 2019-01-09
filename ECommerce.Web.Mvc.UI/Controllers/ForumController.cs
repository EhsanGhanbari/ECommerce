using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Forums;
using ECommerce.Services.Forums.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class ForumController : BaseController
    {
        private readonly IForumService _forumService;

        public ForumController(ICookieStorageService cookieStorageService,IForumService forumService) 
            : base(cookieStorageService)
        {
            _forumService = forumService;
        }


        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// List of all forum
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }

        public ActionResult CreateForum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateForum(ForumViewModel forumViewModel)
        {
            var request = new CreateForumRequest(forumViewModel);
            if (ModelState.IsValid)
            {
                _forumService.CreateForum(request);
            }
            return View();
        }
    }
}
