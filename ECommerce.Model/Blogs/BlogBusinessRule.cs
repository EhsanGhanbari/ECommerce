using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Blogs
{
    public class BlogBusinessRule
    {
        public static readonly BusinessRule TitleRequired = new BusinessRule("Title", "every Blog post has a title");
        public static readonly BusinessRule BodyRequired = new BusinessRule("Body", "Blog posts have a Body");

    }
}
