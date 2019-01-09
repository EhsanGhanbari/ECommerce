using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Blogs
{
    public class BlogCategoryBusinessRule
    {
        public static readonly BusinessRule BodyRequired = new BusinessRule("Name", "Every Category should has a name");

    }
}
