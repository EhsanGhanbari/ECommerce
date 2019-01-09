using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Baskets;
using ECommerce.Model.Customers;
using ECommerce.Model.Orders;
using ECommerce.Model.Payments;
using ECommerce.Services.Orders.Messaging;

namespace ECommerce.Services.Orders
{
    public class OrderService : IOrderService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IBasketRepository _basketRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public OrderService(ICustomerRepository customerRepository, IOrderRepository orderRepository,
             IBasketRepository basketRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
            _basketRepository = basketRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create Order 
        /// product should be in the basket 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            var response = new CreateOrderResponse();
            var customer = _customerRepository.GetById(request.OrderViewModel.Customer.CustomerId);
            var basket = _basketRepository.GetById(request.OrderViewModel.Basket.BasketId);
            var order = request.OrderViewModel.ConvertToOrderModel();
            _orderRepository.Add(order);
            _basketRepository.Remove(basket);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// returns order by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetOrderResponse GetOrder(GetOrderRequest request)
        {
            var response = new GetOrderResponse();
            var order = _orderRepository.GetById(request.OrderViewModel.OrderId);
            response.OrderViewModel = order.ConvertToOrderViewModel();
            return response;
        }



        /// <summary>
        /// Get All Orders of a Customer 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllOrdersResponse GetAllOrders(GetAllOrdersRequest request)
        {
            var response = new GetAllOrdersResponse();
            var order = _orderRepository.GetAll();
            response.OrderViewModels = order.ConverToOrderViewModelList();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveOrderResponse RemoveOrder(RemoveOrderRequest request)
        {
            var response = new RemoveOrderResponse();
            var order = request.OrderViewModel.ConvertToOrderModel();
            _orderRepository.Remove(order);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Updates Orders by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateOrderResponse UpdateOrder(UpdateOrderRequest request)
        {
            var response = new UpdateOrderResponse();
            var order = request.OrderViewModel.ConvertToOrderModel();
            _orderRepository.SaveOrUpdate(order);
            return response;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="setOrderPaymentRequest"></param>
        /// <returns></returns>
        public SetOrderPaymentResponse SetOrderPayment(SetOrderPaymentRequest setOrderPaymentRequest)
        {
            var response = new SetOrderPaymentResponse();
            var order = _orderRepository.GetById(setOrderPaymentRequest.OrderViewModel.OrderId);
            
            try
            {
                order.SetPayment(
                    PaymentFactory.CreatePayment(setOrderPaymentRequest.OrderViewModel.PaymentToken,
                                                 setOrderPaymentRequest.OrderViewModel.Amount,
                                                 setOrderPaymentRequest.OrderViewModel.PaymentMerchant));

                _orderRepository.Add(order);
                _unitOfWork.Commit();

            }
            catch (OrderAlreadyPaidForException ex)
            {
                LoggingFactory.GetLogger().Log(ex.Message);
            }
            catch (PaymentAmountDoesNotEqualOrderTotalException ex)
            {
                LoggingFactory.GetLogger().Log(ex.Message);
            }
            return response;
        }
    }
}
