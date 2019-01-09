using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using ECommerce.Model.Products;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    /// <summary>
    /// CreatesProduct class to create product by vendors
    /// </summary>
    public class CreateProductRequest
    {
        public CreateProductRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }

        internal ProductViewModel ProductViewModel { get; private set; }
        internal IEnumerable<ProductCategory> ProductCategories { get; set; }
        internal IEnumerable<ProductTag> ProductTags { get; set; }
        internal IEnumerable<ProductPicture> ProductPictures { get; set; } 


        //public CreateProductRequest(IEnumerable<ProductCategory> productCategories, IEnumerable<ProductTag> productTags)
        //{
        //    ProductCategories = new List<ProductCategory>(productCategories);
        //    ProductTags = new List<ProductTag>(productTags);
        //}

    }
}
