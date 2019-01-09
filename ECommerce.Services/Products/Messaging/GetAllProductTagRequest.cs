using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class GetAllProductTagRequest
    {
        internal ProductTagViewModel ProductTagViewModel { get; set; }

        public GetAllProductTagRequest(ProductTagViewModel productTagViewModel)
        {
            ProductTagViewModel = productTagViewModel;
        }
    }
}
