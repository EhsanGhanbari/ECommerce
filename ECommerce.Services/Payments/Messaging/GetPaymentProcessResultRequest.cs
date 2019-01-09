namespace ECommerce.Services.Payments.Messaging
{
    public class GetPaymentProcessResultRequest 
    {
        internal PaymentViewModel PaymentViewModel { get; private set; }

        public GetPaymentProcessResultRequest(PaymentViewModel paymentViewModel)
        {
            PaymentViewModel = paymentViewModel;
        }
    }
}
