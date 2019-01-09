using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Model.Shippings;

namespace ECommerce.Services.Shippings
{
    public static class ShippingMapper
    {
        /// <summary>
        /// Convert to Shipping ViewModel
        /// </summary>
        /// <param name="shipping"></param>
        /// <returns></returns>
        public static ShippingViewModel ConvertToShippingViewModel(this Shipping shipping)
        {
            return Mapper.Map<Shipping, ShippingViewModel>(shipping);
        }

        /// <summary>
        /// Convert to Shipping Model
        /// </summary>
        /// <param name="shippingViewModel"></param>
        /// <returns></returns>
        public static Shipping ConverToShippingModel(this ShippingViewModel shippingViewModel)
        {
            return Mapper.Map<ShippingViewModel, Shipping>(shippingViewModel);
        }

        /// <summary>
        /// Convert to Shipping View Model List 
        /// </summary>
        /// <param name="shipping"></param>
        /// <returns></returns>
        public static IEnumerable<ShippingViewModel> ConvertToShippingViewModelList(this IEnumerable<Shipping> shipping)
        {
            return Mapper.Map<IEnumerable<Shipping>, IEnumerable<ShippingViewModel>>(shipping);
        }

    }
}
