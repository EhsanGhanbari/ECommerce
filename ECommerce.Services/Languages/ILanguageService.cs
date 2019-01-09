using ECommerce.Services.Languages.Messaging;

namespace ECommerce.Services.Languages
{
    public interface ILanguageService
    {
        /// <summary>
        /// Create Language by Master or member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateLanguageResponse CreateLanguage(CreateLanguageRequest request);

        /// <summary>
        /// Returns Language of the system
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllLangaugeResponse GetAllLangauge(GetAllLanguageRequest request);

        /// <summary>
        /// returns a languages Details By Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetLanguageResponse GetLanguage(GetLanguageRequest request);

        /// <summary>
        /// Remove a langauge 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveLanguageResponse RemoveLanguage(RemoveLanguageRequest request);


        /// <summary>
        /// Update language 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateLanguageResponse UpdateLanguage(UpdateLanguageRequest request);
    }
}
