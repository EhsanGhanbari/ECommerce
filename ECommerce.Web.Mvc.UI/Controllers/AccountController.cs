using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Accounts;
using ECommerce.Services.Accounts.Messaging;
using ECommerce.Services.Accounts.ViewModel;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class AccountController : BaseAccountController
    {
        private readonly IAccountService _accountService;


        public AccountController(ICookieStorageService cookieStorageService, IAccountService accountService)
            : base(cookieStorageService)
        {
            _accountService = accountService;
        }


        public ActionResult LogOn()
        {
            return View();
        }


        /// <summary>
        /// Create Account Service
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AccountViewModel accountViewModel)
        {
            var request = new CreateAccountRequest();
            
            if (ModelState.IsValid)
            {
                _accountService.CreateAccount(request);
            }
            return View();
        }


        /// <summary>
        /// Edit the account details
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Guid accountId)
        {
            var request = new GetAccountRequest {AccountId = accountId};
            var account = _accountService.GetAccount(request);
            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(AccountViewModel accountViewModel)
        {
            var request = new UpdateAccountRequest(accountViewModel);
            
            if (ModelState.IsValid)
            {
                _accountService.UpdateAccount(request);
            }
            return View();
        }


    }
}
