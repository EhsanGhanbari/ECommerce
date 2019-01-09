namespace ECommerce.Services.Payments.Messaging
{
    public class RefundPaymentResponse : BaseResponse
    {
        internal PaymentViewModel PaymentViewModel { get; set; }
    }
}
