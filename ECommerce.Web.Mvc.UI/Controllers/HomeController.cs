using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICookieStorageService cookieStorageService)
            : base(cookieStorageService)
        {

        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
