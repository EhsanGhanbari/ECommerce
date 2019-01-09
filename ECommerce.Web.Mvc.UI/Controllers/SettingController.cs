using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class SettingController : BaseController
    {
        public SettingController(ICookieStorageService cookieStorageService)
            : base(cookieStorageService)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
