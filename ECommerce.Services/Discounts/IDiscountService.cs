using ECommerce.Services.Discounts.Messaging;

namespace ECommerce.Services.Discounts
{
    public interface IDiscountService
    {
        /// <summary>
        /// Create Discount
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateDiscountResonse CreateDiscount(CreateDiscountRequest request);

        /// <summary>
        /// Returns all discount made befor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllDiscountResponse GetAllDiscount(GetAllDiscountRequest request);

        /// <summary>
        /// Get Discount details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetDiscountResponse GetDiscount(GetDiscountRequest request);

        /// <summary>
        /// Remove a discount
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveDiscountResponse RemoveDiscount(RemoveDiscountRequest request);


        /// <summary>
        /// Edit Discount 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateDiscountResponse UpdateDiscount(UpdateDiscountRequest request);
    }
}
