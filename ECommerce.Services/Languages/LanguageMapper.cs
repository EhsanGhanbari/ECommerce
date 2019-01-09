using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Languages;

namespace ECommerce.Services.Languages
{
    public static class LanguageMapper
    {

        /// <summary>
        /// Convert to language ViewModel
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static LanguageViewModel ConvertToLanguageViewModel(this Language language)
        {
            Mapper.CreateMap<Language, LanguageViewModel>()
                  .ForMember(lan => lan.LanguageId, la => la.MapFrom(l => l.Id));
            return Mapper.Map<Language, LanguageViewModel>(language);
        }


        /// <summary>
        /// Convert to Langauge Model
        /// </summary>
        /// <param name="languageViewModel"></param>
        /// <returns></returns>
        public static Language ConvertToLanguageModel(this LanguageViewModel languageViewModel)
        {
            return Mapper.Map<LanguageViewModel, Language>(languageViewModel);
        }


        /// <summary>
        /// Convert to language View Model
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static IEnumerable<LanguageViewModel> ConvertToLanguageViewModelList(this IEnumerable<Language> language)
        {
            Mapper.CreateMap<Language, LanguageViewModel>()
                  .ForMember(lan => lan.LanguageId, la => la.MapFrom(l => l.Id));
            return Mapper.Map<IEnumerable<Language>, IEnumerable<LanguageViewModel>>(language);
        }

    }
}
