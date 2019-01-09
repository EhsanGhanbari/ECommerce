using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Products
{
    public class ProductBusinnessRule
    {
        public static readonly BusinessRule NameRequired = new BusinessRule("Name", "Product Name Couldn't be a null one");
    }
}
