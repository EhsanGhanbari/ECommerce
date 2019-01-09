using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Stores
{
    [Validator(typeof(StoreViewModel))]
    public class StoreViewModel
    {
        public Guid StoreId { get; set; }
        public string Name { get; set; }


        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
