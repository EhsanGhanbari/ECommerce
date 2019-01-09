namespace ECommerce.Services.Languages.Messaging
{
    public class RemoveLanguageRequest
    {
        internal LanguageViewModel LanguageViewModel { get; private set; }

        public RemoveLanguageRequest(LanguageViewModel languageViewModel)
        {
            LanguageViewModel = languageViewModel;
        }
    }
}
