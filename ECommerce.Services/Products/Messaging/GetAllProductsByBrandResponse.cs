using System.Collections.Generic;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductsByBrandResponse : BaseResponse
    {
        public IEnumerable<ProductViewModel> ProductViewModels { get; set; }
    }
}
