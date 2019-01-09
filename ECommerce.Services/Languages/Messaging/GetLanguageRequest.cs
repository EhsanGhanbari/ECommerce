namespace ECommerce.Services.Languages.Messaging
{
    public class GetLanguageRequest 
    {
        internal LanguageViewModel LanguageViewModel { get; private set; }

        public GetLanguageRequest(LanguageViewModel languageViewModel)
        {
            LanguageViewModel = languageViewModel;
        }
    }
}
