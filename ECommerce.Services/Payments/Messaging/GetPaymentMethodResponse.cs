namespace ECommerce.Services.Payments.Messaging
{
    public class GetPaymentMethodResponse :BaseResponse 
    {
        public PaymentViewModel PaymentViewModel { get; set; }
    }
}
