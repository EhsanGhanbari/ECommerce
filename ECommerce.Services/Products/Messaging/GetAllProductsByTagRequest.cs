using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductsByTagRequest
    {
        internal ProductViewModel ProductViewModel { get; set; }
        internal ProductTagViewModel ProductTagViewModel { get; set; }

        public GetAllProductsByTagRequest(ProductViewModel productViewModel)
        {
            ProductViewModel = productViewModel;
        }

        public GetAllProductsByTagRequest(ProductTagViewModel productTagViewModel)
        {
            ProductTagViewModel = productTagViewModel;
        }

    }
}
