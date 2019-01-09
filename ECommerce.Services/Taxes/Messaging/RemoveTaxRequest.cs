using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Taxes.Messaging
{
    public class RemoveTaxRequest
    {
        internal TaxViewModel TaxViewModel { get; set; }

        public RemoveTaxRequest(TaxViewModel taxViewModel)
        {
            TaxViewModel = taxViewModel;
        }
    }
}
