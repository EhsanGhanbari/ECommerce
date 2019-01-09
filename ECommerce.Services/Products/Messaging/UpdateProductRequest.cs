using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class UpdateProductRequest
    {
        internal  ProductViewModel ProductViewModel { get; private set; }

        public UpdateProductRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }
    }
}
