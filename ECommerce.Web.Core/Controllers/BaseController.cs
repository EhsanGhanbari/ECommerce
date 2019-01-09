using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Languages;

namespace ECommerce.Web.Core.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICookieStorageService _cookieStorageService;
      //  private readonly ILanguageService _languageService;

        public BaseController(ICookieStorageService cookieStorageService)//,ILanguageService languageService)
        {
            _cookieStorageService = cookieStorageService;
           // _languageService = languageService;
        }
    }
}
