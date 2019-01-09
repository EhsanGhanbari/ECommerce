using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class RemoveProductRequest
    {
        internal ProductViewModel ProductViewModel { get; private set; }
      
        public RemoveProductRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }
    }
}
