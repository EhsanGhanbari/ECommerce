using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Products
{
    public interface IProductAttribute
    {
        string Name { get; }
        bool ShowOnHomePage { get; }
        bool Deleted { get; }
    }
}
