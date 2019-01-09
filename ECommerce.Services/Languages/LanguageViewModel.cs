using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Languages
{
    [Validator(typeof(LanguageValidation))]
    public class LanguageViewModel
    {
        public Guid LanguageId { get; set; }
        public string Name { get; set; }
    }
}
