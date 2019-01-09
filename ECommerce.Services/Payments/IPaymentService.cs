using ECommerce.Services.Payments.Messaging;

namespace ECommerce.Services.Payments
{
    public interface IPaymentService
    {
       // RefundPaymentResult Refund(RefundPaymentRequest refundPaymentRequest);
       // CancelRecurringPaymentResult CancelRecurringPayment(CancelRecurringPaymentRequest cancelPaymentRequest);
        //   ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest);
        //  IList<IPaymentMethod> LoadActivePaymentMethods(int? filterByCustomerId = null);
        //   IList<IPaymentMethod> LoadAllPaymentMethods();
        //  RefundPaymentResult Refund(RefundPaymentRequest refundPaymentRequest);
       // CancelRecurringPaymentResult CancelRecurringPayment(CancelRecurringPaymentRequest cancelPaymentRequest);
        //


        /// <summary>
        /// Add an existing payment method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreatePaymentMethodResponse CreatePaymentMethod(CreatePaymentMethodRequest request);

        /// <summary>
        /// Get All payment method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllPaymentMethodsResponse GetAllPaymentMethods(GetAllPaymentMethodsRequest request);


        /// <summary>
        /// returns the payment method details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetPaymentMethodResponse GetPaymentMethod(GetPaymentMethodRequest request);


        /// <summary>
        /// Get Payment Process result
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetPaymentProcessResultResponse GetPaymentProcessResult(GetPaymentProcessResultRequest request);


        /// <summary>
        /// Refund payment, Repayment process
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RefundPaymentResponse RefundPayment(RefundPaymentRequest request);
    }
}
