using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Lotteries;
using ECommerce.Services.Lotteries.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class LotteryController : BaseController
    {
        private readonly ILotteryService _lotteryService;

        public LotteryController(ICookieStorageService cookieStorageService,ILotteryService lotteryService) 
        
            : base(cookieStorageService)
        {
            _lotteryService = lotteryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Create Lottery by Admin
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LotteryViewModel lotteryViewModel)
        {
            var request = new CreateLotteryRequest(lotteryViewModel);
            
            if (ModelState.IsValid)
            {
                _lotteryService.CreateLottery(request);
            }
            return View();
        }
        
    }
}
