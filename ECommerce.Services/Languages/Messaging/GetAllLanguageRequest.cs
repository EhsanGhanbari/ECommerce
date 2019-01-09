namespace ECommerce.Services.Languages.Messaging
{
    public class GetAllLanguageRequest
    {
        internal LanguageViewModel LanguageViewModel { get; private set; }

        public GetAllLanguageRequest(LanguageViewModel languageViewModel)
        {
            LanguageViewModel = languageViewModel;
        }
    }
}
