using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Contacts;
using ECommerce.Services.Managements.Contacts;
using ECommerce.Services.Managements.Contacts.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class ContactController : BaseController
    {
        private readonly IContactService _contactService;

        public ContactController(ICookieStorageService cookieStorageService, IContactService contactService)
            : base(cookieStorageService)
        {
            _contactService = contactService;
        }


        /// <summary>
        /// list of all made contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Inbox()
        {
            var contactViewModel = new ContactViewModel();
            var request = new GetAllContactsRequest(contactViewModel);
            var contacts = _contactService.GetAllContacts(request);
            return View("Inbox", contacts.ContactViewModels);
        }


        /// <summary>
        /// Details of the contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            var contactViewModel = new ContactViewModel();
            var request = new GetContactRequest(contactViewModel);
            var contact = _contactService.GetContact(request);
            return View("Detail", contact);
        }


        /// <summary>
        /// Create contact 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ContactViewModel contactViewModel)
        {
            var request = new CreateContactRequest(contactViewModel);
            _contactService.CreateContact(request);
            return View();
        }

        /// <summary>
        /// Remove a contact from inbox
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Remove(ContactViewModel contactViewModel)
        {
            var request = new RemoveContactRequest(contactViewModel);

            if (ModelState.IsValid)
            {
                _contactService.RemoveContact(request);
            }
            return Json("");
        }




        /// <summary>
        /// used in reply to a message
        /// </summary>
        /// <returns></returns>
        public ActionResult Reply()
        {
            return View();
        }


    }
}
