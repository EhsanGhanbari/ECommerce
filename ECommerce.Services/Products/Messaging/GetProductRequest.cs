using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetProductRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }

        public GetProductRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }
    }
}
