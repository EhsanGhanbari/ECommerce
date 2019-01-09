namespace ECommerce.Services.Discounts.Messaging
{
    public class UpdateDiscountRequest
    {
        internal DiscountViewModel DiscountViewModel { get; private set; }

        public UpdateDiscountRequest(DiscountViewModel discountViewModel)
        {
            DiscountViewModel = discountViewModel;
        }
    }
}
