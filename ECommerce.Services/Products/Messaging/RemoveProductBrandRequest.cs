using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Products.VeiwModels;

namespace ECommerce.Services.Products.Messaging
{
    public class RemoveProductBrandRequest 
    {
        internal ProductBrandViewModel ProductBrandViewModel { get; private set; }
        
        public RemoveProductBrandRequest(ProductBrandViewModel productBrandViewModel)
        {
            ProductBrandViewModel = productBrandViewModel;
        }
    }
}
