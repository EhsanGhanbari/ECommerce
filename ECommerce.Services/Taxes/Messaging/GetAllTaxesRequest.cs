using ECommerce.Services.Taxes;

namespace ECommerce.Services.Taxes.Messaging
{
    public class GetAllTaxesRequest
    {
        internal TaxViewModel TaxViewModel { get; private set; }

        public GetAllTaxesRequest(TaxViewModel taxViewModel)
        {
            TaxViewModel = taxViewModel;
        }
    }
}
