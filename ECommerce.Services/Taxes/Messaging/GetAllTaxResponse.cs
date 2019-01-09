using System.Collections.Generic;
using ECommerce.Services.Taxes;

namespace ECommerce.Services.Taxes.Messaging
{
    public class GetAllTaxesResponse
    {
        public IEnumerable<TaxViewModel> TaxViewModels { get; set; } 
    }
}
