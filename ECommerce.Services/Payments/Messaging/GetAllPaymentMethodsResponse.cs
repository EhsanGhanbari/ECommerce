using System.Collections.Generic;

namespace ECommerce.Services.Payments.Messaging
{
    public class GetAllPaymentMethodsResponse : BaseResponse
    {
        public IEnumerable<PaymentViewModel> PaymentViewModels { get; set; } 
    }
}
