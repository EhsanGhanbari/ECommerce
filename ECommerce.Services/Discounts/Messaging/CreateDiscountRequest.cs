namespace ECommerce.Services.Discounts.Messaging
{
    public class CreateDiscountRequest
    {
        internal DiscountViewModel DiscountViewModel { get; private set; }

        public CreateDiscountRequest(DiscountViewModel discountViewModel)
        {
            DiscountViewModel = discountViewModel;
        }
    }
}
