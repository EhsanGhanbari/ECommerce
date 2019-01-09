using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Payments;
using ECommerce.Services.Payments.Messaging;

namespace ECommerce.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public PaymentService(IPaymentRepository paymentRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _paymentRepository = paymentRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreatePaymentMethodResponse CreatePaymentMethod(CreatePaymentMethodRequest request)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllPaymentMethodsResponse GetAllPaymentMethods(GetAllPaymentMethodsRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetPaymentMethodResponse GetPaymentMethod(GetPaymentMethodRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetPaymentProcessResultResponse GetPaymentProcessResult(GetPaymentProcessResultRequest request)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RefundPaymentResponse RefundPayment(RefundPaymentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
