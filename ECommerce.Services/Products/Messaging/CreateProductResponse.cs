using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    /// <summary>
    /// Create product response
    /// </summary>
    public class CreateProductResponse : BaseResponse
    {
        public ProductViewModel ProductViewModel { get; set; }
    }
}
