using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Baskets;
using ECommerce.Model.Orders;

namespace ECommerce.Services.Orders
{
    public static class OrderMapper
    {
        /// <summary>
        /// Convert to Order View Model
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static OrderViewModel ConvertToOrderViewModel(this Order order)
        {
           return Mapper.Map<Order, OrderViewModel>(order);
        }


        /// <summary>
        /// Convert to Order ViewModel list
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public static IEnumerable<OrderViewModel> ConverToOrderViewModelList(this IEnumerable<Order> orders)
        {
            return Mapper.Map<IEnumerable<Order>, IEnumerable<OrderViewModel>>(orders);
        }


        /// <summary>
        /// Convert to Order ViewModel
        /// </summary>
        /// <param name="orderViewModel"></param>
        /// <returns></returns>
        public static Order ConvertToOrderModel(this OrderViewModel orderViewModel)
        {
            return Mapper.Map<OrderViewModel, Order>(orderViewModel);
        }
    }
}
