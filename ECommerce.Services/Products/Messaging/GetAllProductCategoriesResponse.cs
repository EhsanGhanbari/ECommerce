using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductCategoriesResponse : BaseResponse
    {
        public IEnumerable<ProductCategoryViewModel> ProductCategoryViewModels { get; set; }
    }
}
