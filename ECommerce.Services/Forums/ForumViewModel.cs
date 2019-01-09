using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Forums
{
    [Validator(typeof(ForumValidation))]
    public class ForumViewModel
    {
        public Guid ForumId { get; set; }
    }
}
