using ECommerce.Services.Taxes;

namespace ECommerce.Services.Taxes.Messaging
{
    public class UpdateTaxRequest
    {
        internal TaxViewModel TaxViewModel { get; private set; }

        public UpdateTaxRequest(TaxViewModel taxViewModel)
        {
            TaxViewModel = taxViewModel;
        }
    }
}
