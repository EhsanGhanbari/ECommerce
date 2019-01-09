using System;
using ECommerce.Model.Products;
using FluentValidation.Attributes;

namespace ECommerce.Services.Products.VeiwModels
{
    [Validator(typeof(ProductValidation))]
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool AllowComment { get; set; }
        public ProductCategoryViewModel ProductCategoryViewModel { get; set; }
        public ProductBrandViewModel ProductBrandViewModel { get; set; }
        public ProductColorViewModel ProductColorViewModel { get; set; }
        public ProductSizeViewModel  ProductSizeViewModel { get; set; }
        public ProductTagViewModel ProductTagViewModel { get; set; }
        public ProductManufacturerViewModel ProductManufacturerViewModel { get; set; }
        public ProductPictureViewModel ProductPicture { get; set; }

    }
}
