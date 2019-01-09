using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Affiliates;

namespace ECommerce.Services.Affiliates
{
    public static class AffiliateMapper
    {
        /// <summary>
        /// Convert to Affiliate ViewModel
        /// </summary>
        /// <param name="affiliate"></param>
        /// <returns></returns>
        public static AffiliateViewModel ConvertToAffiliateViewModel(this Affiliate affiliate)
        {
            Mapper.CreateMap<Affiliate, AffiliateViewModel>()
                  .ForMember(aff => aff.AffiliateId, af => af.MapFrom(a => a.Id));
            return Mapper.Map<Affiliate, AffiliateViewModel>(affiliate);
        }


        /// <summary>
        /// Convert to Affiliate Model
        /// </summary>
        /// <param name="affiliateViewModel"></param>
        /// <returns></returns>
        public static Affiliate ConvertToAffiliateModel(this AffiliateViewModel affiliateViewModel)
        {
            return Mapper.Map<AffiliateViewModel, Affiliate>(affiliateViewModel);
        }


        /// <summary>
        /// Convert to Affiliate ViewModel list
        /// </summary>
        /// <param name="affiliate"></param>
        /// <returns></returns>
        public static IEnumerable<AffiliateViewModel> ConvertToAffiliateViewModelList(this IEnumerable<Affiliate> affiliate)
        {
            Mapper.CreateMap<Affiliate, AffiliateViewModel>()
                  .ForMember(aff => aff.AffiliateId, af => af.MapFrom(a => a.Id));
            return Mapper.Map<IEnumerable<Affiliate>, IEnumerable<AffiliateViewModel>>(affiliate);
        }

    }
}
