namespace ECommerce.Services.Discounts.Messaging
{
    public class RemoveDiscountRequest
    {
        internal DiscountViewModel DiscountViewModel { get; private set; }

        public RemoveDiscountRequest(DiscountViewModel discountViewModel)
        {
            DiscountViewModel = discountViewModel;
        }
    }
}
