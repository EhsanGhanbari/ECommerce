namespace ECommerce.Services.Payments.Messaging
{
    public class GetPaymentMethodRequest
    {
        internal PaymentViewModel PaymentViewModel { get; private set; }

        public GetPaymentMethodRequest(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel = paymentViewModel;
        }
    }
}
