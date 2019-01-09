using System;
using ECommerce.Model.Media;
using FluentValidation.Attributes;

namespace ECommerce.Services.Newses.ViewModels
{
    [Validator(typeof(NewsValidation))]
    public class NewsViewModel
    {
        public Guid NewsId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Summary { get; set; }
        public Picture Image { get; set; }
        public DateTime CreationTime { get; set; }
        public string PostSlug { get; set; }
        public string NewsTagName { get; set; }
    }
}
