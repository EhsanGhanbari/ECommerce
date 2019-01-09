using ECommerce.CrossCutting.StorageService;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class SecurityController : BaseController
    {
        public SecurityController(ICookieStorageService cookieStorageService)
            : base(cookieStorageService)
        {
        }
    }
}
