using System;
using System.Web.Mvc;
using ECommerce.CrossCutting.StorageService;
using ECommerce.Services.Orders;
using ECommerce.Services.Orders.Messaging;
using ECommerce.Web.Core.Controllers;

namespace ECommerce.Web.Mvc.UI.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(ICookieStorageService cookieStorageService,IOrderService orderService) 
            : base(cookieStorageService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// returns all orders 
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }


        /// <summary>
        /// Admin could Create Order to a member of customer as a helper!
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(OrderViewModel orderViewModel)
        {
            var request = new CreateOrderRequest(orderViewModel);

            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(request);
            }
            return View("Create");
        }


        /// <summary>
        /// More Details about an Order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public ActionResult More(Guid orderId)
        {
            var orderViewModel = new OrderViewModel();
            var request = new GetOrderRequest(orderViewModel);
            var order = _orderService.GetOrder(request);
            return View("More", order);
        }



        /// <summary>
        /// Edit Order if it's not shipped yet !
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Guid orderId)
        {
            var orderViewModel = new OrderViewModel();
            var request = new GetOrderRequest(orderViewModel);
            var order = _orderService.GetOrder(request);
            return View("Edit", order.OrderViewModel);
        }

        [HttpPost]
        public ActionResult Edit(OrderViewModel orderViewModel)
        {
            var request = new UpdateOrderRequest(orderViewModel);

            if (ModelState.IsValid)
            {
                _orderService.UpdateOrder(request);
            }
            return View("Edit");
        }




        public ActionResult Remove()
        {
            return View();
        }
    }
}
