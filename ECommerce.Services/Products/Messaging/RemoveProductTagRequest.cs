using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Model.Forums;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class RemoveProductTagRequest
    {
        internal ProductTagViewModel ProductTagViewModel { get; set; }

        public RemoveProductTagRequest(ProductTagViewModel productTagViewModel)
        {
            ProductTagViewModel = productTagViewModel;
        }
    }
}
