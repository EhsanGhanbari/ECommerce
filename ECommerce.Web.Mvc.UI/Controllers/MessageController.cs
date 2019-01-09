using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Messages;
using ECommerce.Services.Messages.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService _messageService;


        public MessageController(ICookieStorageService cookieStorageService, IMessageService messageService)
            : base(cookieStorageService)
        {
            _messageService = messageService;
        }

        public ActionResult List()
        {
            return View();
        }


        /// <summary>
        /// Createa Message by Admin to a member
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(MessageViewModel messageViewModel)
        {
            var request = new CreateMessageRequest(messageViewModel);

            if (ModelState.IsValid)
            {
                _messageService.CreateMessage(request);
            }
            return View("Create");
        }


        /// <summary>
        /// More Details about message
        /// </summary>
        /// <returns></returns>
        public ActionResult More()
        {
            var messageViewModel = new MessageViewModel();
            var request = new GetMessageRequest(messageViewModel);
            var message = _messageService.GetMessage(request);
            return View("More",message);
        }
    }
}
