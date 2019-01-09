using ECommerce.Services.Taxes;

namespace ECommerce.Services.Taxes.Messaging
{
    public class CreateTaxRequest
    {
        internal TaxViewModel TaxViewModel { get; private set; }

        public CreateTaxRequest(TaxViewModel taxViewModel)
        {
            TaxViewModel = taxViewModel;
        }
    }
}
