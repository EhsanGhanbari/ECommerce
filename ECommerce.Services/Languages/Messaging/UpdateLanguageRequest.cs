namespace ECommerce.Services.Languages.Messaging
{
    public class UpdateLanguageRequest
    {
        internal LanguageViewModel LanguageViewModel { get; private set; }

        public UpdateLanguageRequest(LanguageViewModel languageViewModel)
        {
            LanguageViewModel = languageViewModel;
        }
    }
}
