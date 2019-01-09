namespace ECommerce.Services.Payments.Messaging
{
    public class CreatePaymentMethodRequest
    {
        internal PaymentViewModel PaymentViewModel { get; private set; }

        public CreatePaymentMethodRequest(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel = paymentViewModel;
        }
    }
}
