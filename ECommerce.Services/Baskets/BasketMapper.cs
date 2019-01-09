using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Baskets;

namespace ECommerce.Services.Baskets
{
    public static class BasketMapper
    {

        /// <summary>
        /// Convert to Basket ViewModel
        /// </summary>
        /// <param name="basket"></param>
        /// <returns></returns>
        public static BasketViewModel ConvertToBasketViewModel(this Basket basket)
        {
            return Mapper.Map<Basket, BasketViewModel>(basket);
        }



        /// <summary>
        /// Convert to Basket Model
        /// </summary>
        /// <param name="basketViewModel"></param>
        /// <returns></returns>
        public static Basket ConvertToBasketModel(this BasketViewModel basketViewModel)
        {
            return Mapper.Map<BasketViewModel, Basket>(basketViewModel);
        }



        /// <summary>
        /// Convert to Basket View Model
        /// </summary>
        /// <param name="basket"></param>
        /// <returns></returns>
        public static IEnumerable<BasketViewModel> ConvertToBasketViewModelList(this IEnumerable<Basket> basket)
        {
            return Mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basket);
        }
    }
}
