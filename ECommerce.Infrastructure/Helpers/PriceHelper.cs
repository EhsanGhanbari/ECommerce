using System;

namespace ECommerce.Infrastructure.Helpers
{
    public static class PriceHelper
    {
        //Us Dollars
        public static string FormatMoney(this decimal price)
        {
            return String.Format("${0}", price);
        }

    }
}
