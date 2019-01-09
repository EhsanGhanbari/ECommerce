using System;
using ECommerce.Model.Products;
using FluentValidation.Attributes;

namespace ECommerce.Services.Groups
{
    [Validator(typeof(GroupValidation))]
    public class GroupViewModel
    {

        public Guid GroupId { get; set; }
        public string Name { get; set; }


        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }


        public ProductBrand ProductBrand { get; set; }

    }
}
