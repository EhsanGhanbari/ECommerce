using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Blogs
{
    public static class BlogTagBusinessRule
    {
        public static readonly BusinessRule BodyRequired = new BusinessRule("Name", "Every tag should has a name");
    }
}
