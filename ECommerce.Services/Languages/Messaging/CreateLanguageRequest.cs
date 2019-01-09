namespace ECommerce.Services.Languages.Messaging
{
    public class CreateLanguageRequest
    {
        internal LanguageViewModel LanguageViewModel { get; private set; }

        public CreateLanguageRequest(LanguageViewModel languageViewModel)
        {
            LanguageViewModel = languageViewModel;
        }
    }
}
