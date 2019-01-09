using ECommerce.Services.Taxes.Messaging;

namespace ECommerce.Services.Taxes
{
    public interface ITaxService
    {

        /// <summary>
        /// Creates a new tax 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateTaxResponse CreateTax(CreateTaxRequest request);

        /// <summary>
        /// Get All taxes method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllTaxesResponse GetAllTaxes(GetAllTaxesRequest request);


        /// <summary>
        /// Get a tax in detail
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetTaxResponse GetTax(GetTaxRequest request);


        /// <summary>
        /// Removes a tax 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveTaxResponse RemoveTax(RemoveTaxRequest request);


        /// <summary>
        /// Updates a tax 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateTaxResponse UpdateTax(UpdateTaxRequest request);

    }
}
