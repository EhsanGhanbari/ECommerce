using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Baskets
{
    public class BasketItemBusinessRules
    {
        public static readonly BusinessRule BasketRequired = new BusinessRule("Basket",
                                                                              "A basket item must be related to a basket");

        public static readonly BusinessRule ProductRequired = new BusinessRule("Product",
                                                                               "A basket item must be related to a Product");

    }
}
