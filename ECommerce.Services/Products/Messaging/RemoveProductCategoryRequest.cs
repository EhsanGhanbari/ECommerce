using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class RemoveProductCategoryRequest
    {
        internal ProductCategoryViewModel ProductCategoryViewModel { get; private set; }
        public RemoveProductCategoryRequest(ProductCategoryViewModel productCategoryViewModel)
        {
            ProductCategoryViewModel = productCategoryViewModel;
        }
    }
}
