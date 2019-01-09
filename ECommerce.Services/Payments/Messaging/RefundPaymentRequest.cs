namespace ECommerce.Services.Payments.Messaging
{
    public class RefundPaymentRequest
    {
        internal PaymentViewModel PaymentViewModel { get; private set; }

        public RefundPaymentRequest(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel = paymentViewModel;
        }
    }
}
