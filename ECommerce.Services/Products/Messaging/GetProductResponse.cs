using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    /// <summary>
    /// Get product response
    /// </summary>
    public class GetProductResponse : BaseResponse
    {
        public ProductViewModel ProductViewModel { get; set; }
    }
}
