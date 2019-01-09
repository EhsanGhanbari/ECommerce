using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }

        public GetAllProductRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }
    }
}
