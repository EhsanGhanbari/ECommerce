using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Discounts;

namespace ECommerce.Services.Discounts
{
    public static class DiscountMapper
    {

        /// <summary>
        /// Convert to Discount View Model
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public static DiscountViewModel ConvertToDiscountViewModel(this Discount discount)
        {
            Mapper.CreateMap<Discount, DiscountViewModel>()
                  .ForMember(dis => dis.DiscountId, di => di.MapFrom(c => c.Id));
            return Mapper.Map<Discount, DiscountViewModel>(discount);
        }



        /// <summary>
        /// Convert to Discount Model
        /// </summary>
        /// <param name="discountViewModel"></param>
        /// <returns></returns>
        public static Discount ConveretToDiscountModel(this DiscountViewModel discountViewModel)
        {
           return Mapper.Map<DiscountViewModel, Discount>(discountViewModel);
        }



        /// <summary>
        /// Converts to a list of dicounse
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        public static IEnumerable<DiscountViewModel> ConvertToDiscountViewModelList(this IEnumerable<Discount> discount)
        {
            Mapper.CreateMap<Discount, DiscountViewModel>()
                  .ForMember(dis => dis.DiscountId, di => di.MapFrom(c => c.Id));
            return Mapper.Map<IEnumerable<Discount>, IEnumerable<DiscountViewModel>>(discount);
        }
    }
}
