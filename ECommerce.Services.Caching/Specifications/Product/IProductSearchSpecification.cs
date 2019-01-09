namespace ECommerce.Services.Caching.Specifications.Product
{
    public interface IProductSearchSpecification
    {
        bool IsSatisfiedBy(Model.Products.Product product);
    }
   
}
