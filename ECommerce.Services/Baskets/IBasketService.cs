using ECommerce.Services.Baskets.Messaging;

namespace ECommerce.Services.Baskets
{
    public interface IBasketService
    {
        
        /// <summary>
        /// Add Items to basket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateBasketItemsResponse CreateBasketItems(CreateBasketItemsRequest request);

        /// <summary>
        /// Get Basket Item 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetBasketResponse GetBasketItem(GetBasketRequest request);
   
        /// <summary>
        /// Get All Unshipped Items in Basket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllBasketItemsResponse GetAllBasketItems(GetAllBasketItemsRequest request);

        /// <summary>
        /// Remove Items from basket
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveBasketItemResponse RemoveBasketItems(RemoveBasketItemRequest request);

        /// <summary>
        /// Update BasketItem
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateBasketItemResponse UpdateBasketItems(UpdateBasketItemRequest request);
    }
}
