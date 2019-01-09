using System.Web.Mvc;
using System.Web.Security;
using ECommerce.CrossCutting.Authentication;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Accounts;
using ECommerce.Services.Accounts.ViewModel;

namespace ECommerce.Web.Core.Controllers
{

    /// <summary>
    /// Account controller and membership of the system 
    /// </summary>
    public class AccountController : BaseController
    {
        private readonly IFormsAuthentication _authentication;
        private readonly IUserAuthenticationService _authenticationService;
        private readonly IAccountService _accountService;

        public AccountController(ICookieStorageService cookieStorageService,
            IFormsAuthentication authentication,
            IUserAuthenticationService authenticationService,
            IAccountService accountService)

            : base(cookieStorageService)
        {
            _authenticationService = authenticationService;
            _authentication = authentication;
            _accountService = accountService;
        }



        /// <summary>
        /// LogOn action 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult LogOn()
        {
            return View();
        }

        /// <summary>
        /// LogOn post action
        /// </summary>
        /// <param name="logOnViewModel"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult LogOn(LogOnViewModel logOnViewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _authenticationService.Login(logOnViewModel.UserName, logOnViewModel.Password);

                if (user.IsAuthenticated)
                {
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "UserName or password is Wrong!");
                }
            }
            return View();

        }


        /// <summary>
        /// Logoff action 
        /// redirects the member to the logon view
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            _authentication.SignOut();
            return RedirectToAction("logOn", "Account");
        }




        /// <summary>
        /// Register User   
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View("Register");
        }


        [HttpPost]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                //    _authenticationService.RegisterUser(registerViewModel);
            }
            return View();
        }

        protected override void ExecuteCore()
        {
            throw new System.NotImplementedException();
        }
    }
}
