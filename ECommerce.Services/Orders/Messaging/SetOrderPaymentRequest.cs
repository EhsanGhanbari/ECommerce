using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Payments;

namespace ECommerce.Services.Orders.Messaging
{
    public class SetOrderPaymentRequest
    {
        internal OrderViewModel OrderViewModel { get; private set; }

        public SetOrderPaymentRequest(OrderViewModel paymentViewModel)
        {
            OrderViewModel = paymentViewModel;
        }
    }
}
