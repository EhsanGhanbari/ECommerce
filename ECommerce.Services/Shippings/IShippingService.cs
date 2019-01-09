using ECommerce.Services.Shippings.Messaging;

namespace ECommerce.Services.Shippings
{
    public interface IShippingService
    {

        /// <summary>
        /// Create Shipping Method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateShippingMethodResponse CreateShippingMethod(CreateShippingMethodRequest request);


        /// <summary>
        /// Get All Shipping Methods
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllShippingMethodsResponse GetAllShippingMethods(GetAllShippingMethodsRequest request);


        /// <summary>
        /// Get Shipping Method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetShippingMethodResponse GetShippingMethod(GetShippingMethodRequest request);


        /// <summary>
        /// Remove Shipping Method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveShippingMethodResponse RemoveShippingMethod(RemoveShippingMethodRequest request);


        /// <summary>
        /// Update Shipping method
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateShippingMethodResponse UpdateShippingMethod(UpdateShippingMethodRequest request);
    }
}
