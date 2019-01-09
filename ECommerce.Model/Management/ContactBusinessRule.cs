using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Management
{
    public class ContactBusinessRule
    {
        public static readonly BusinessRule EmailRequired = new BusinessRule("Email", "Email can not be Empty");

        public static readonly BusinessRule MessageTitleRequired = new BusinessRule("MessageTitle",
                                                                                    "Message Title couldn't be empty");

        public static readonly BusinessRule MessageBodyRequired = new BusinessRule("MessageBody",
                                                                                   "MessageBody couldn't be empty");

    }
}
