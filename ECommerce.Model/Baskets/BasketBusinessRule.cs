using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Baskets
{
    public class BasketBusinessRule
    {
        public static readonly BusinessRule DeliveryOptionRequired =
                   new BusinessRule("DeliveryOption",
                                       "An order must have a valid delivery option.");
        public static readonly BusinessRule ItemInvalid =
                    new BusinessRule("Item", "A basket cannot have any invalid items.");
    }
}
