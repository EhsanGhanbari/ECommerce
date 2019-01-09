using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductsByCategoryRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }
        internal ProductCategoryViewModel ProductCategoryViewModel { get; private set; }

        public GetAllProductsByCategoryRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }

        public GetAllProductsByCategoryRequest(ProductCategoryViewModel productCategoryViewModel)
        {
            ProductCategoryViewModel = productCategoryViewModel;
        }

    }
}
