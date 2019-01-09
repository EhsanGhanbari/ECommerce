using System.Collections.Generic;

namespace ECommerce.Services.Languages.Messaging
{
    public class GetAllLangaugeResponse
    {
        public IEnumerable<LanguageViewModel> LanguageViewModels { get; set; }
    }
}
