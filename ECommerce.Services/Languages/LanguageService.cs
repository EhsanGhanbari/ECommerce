using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Languages;
using ECommerce.Services.Languages.Messaging;

namespace ECommerce.Services.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LanguageService(ILanguageRepository languageRepository,IUnitOfWork unitOfWork)
        {
            _languageRepository = languageRepository;
            _unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Add a language to the sysyem
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateLanguageResponse CreateLanguage(CreateLanguageRequest request)
        {
            var response = new CreateLanguageResponse();
            var language = request.LanguageViewModel.ConvertToLanguageModel();
            _languageRepository.Add(language);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllLangaugeResponse GetAllLangauge(GetAllLanguageRequest request)
        {
            var response = new GetAllLangaugeResponse();
            var languages = _languageRepository.GetAll();
            response.LanguageViewModels = languages.ConvertToLanguageViewModelList();
            return response;
        }


        /// <summary>
        /// GetLanguage by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetLanguageResponse GetLanguage(GetLanguageRequest request)
        {
            var response = new GetLanguageResponse();
            var language = _languageRepository.GetById(request.LanguageViewModel.LanguageId);
            response.LanguageViewModel = language.ConvertToLanguageViewModel();
            return response;
        }


        /// <summary>
        /// Remove a language by Identity 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveLanguageResponse RemoveLanguage(RemoveLanguageRequest request)
        {
            var response = new RemoveLanguageResponse();
            var languageViewModel = request.LanguageViewModel;
            var language = languageViewModel.ConvertToLanguageModel();
            _languageRepository.Remove(language);
            return response;
        }


        /// <summary>
        /// Update language Content 
        ///  </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateLanguageResponse UpdateLanguage(UpdateLanguageRequest request)
        {
            var response = new UpdateLanguageResponse();
            var languageViewModel = request.LanguageViewModel;
            var language = languageViewModel.ConvertToLanguageModel();
            _languageRepository.SaveOrUpdate(language);

            return response;
        }
    }
}
