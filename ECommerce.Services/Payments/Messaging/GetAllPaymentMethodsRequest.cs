namespace ECommerce.Services.Payments.Messaging
{
    public class GetAllPaymentMethodsRequest
    {
        internal PaymentViewModel PaymentViewModel { get; private set; }

        public GetAllPaymentMethodsRequest(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel = paymentViewModel;
        }
    }
}
