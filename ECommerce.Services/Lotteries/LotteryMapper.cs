using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Lotteries;

namespace ECommerce.Services.Lotteries
{
    public static class LotteryMapper
    {
        /// <summary>
        /// Convert to Lottery View Model
        /// </summary>
        /// <param name="lottery"></param>
        /// <returns></returns>
        public static LotteryViewModel ConvertToLotteryViewModel(this Lottery lottery)
        {
            return Mapper.Map<Lottery, LotteryViewModel>(lottery);
        }

        /// <summary>
        /// Convert to lottery Model
        /// </summary>
        /// <param name="lotteryViewModel"></param>
        /// <returns></returns>
        public static Lottery ConvertToLotteryModel(this LotteryViewModel lotteryViewModel)
        {
            return Mapper.Map<LotteryViewModel, Lottery>(lotteryViewModel);
        }


        /// <summary>
        /// Converet to Lottery View Model List 
        /// </summary>
        /// <param name="lottery"></param>
        /// <returns></returns>
        public static IEnumerable<LotteryViewModel> ConvertToLotteryViewModelList(this IEnumerable<Lottery> lottery)
        {
            return Mapper.Map<IEnumerable<Lottery>, IEnumerable<LotteryViewModel>>(lottery);
        }

    }
}
