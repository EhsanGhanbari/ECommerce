using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductsByBrandRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }
        internal ProductBrandViewModel ProductBrandViewModel { get; set; }

        public GetAllProductsByBrandRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }

        public GetAllProductsByBrandRequest(ProductBrandViewModel productBrandViewModel)
        {
            ProductBrandViewModel = productBrandViewModel;
        }


    }
}
