using ECommerce.Services.Orders.Messaging;

namespace ECommerce.Services.Orders
{
    public interface IOrderService
    {
        /// <summary>
        /// Create Oreder 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateOrderResponse CreateOrder(CreateOrderRequest request);

        
        /// <summary>
        /// Get Order by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetOrderResponse GetOrder(GetOrderRequest request);


        /// <summary>
        /// Returns All Orders of the system
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllOrdersResponse GetAllOrders(GetAllOrdersRequest request);


        /// <summary>
        /// removes the order 
        /// order will be checked if it's shipped or not
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveOrderResponse RemoveOrder(RemoveOrderRequest request);

        
        /// <summary>
        /// updates the order
        /// order will be checked if it's shipped or not
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateOrderResponse UpdateOrder(UpdateOrderRequest request);


        /// <summary>
        /// Sets and modifies the order payment
        /// </summary>
        /// <param name="setOrderPaymentRequest"></param>
        /// <returns></returns>
        SetOrderPaymentResponse SetOrderPayment(SetOrderPaymentRequest setOrderPaymentRequest);


    }
}
