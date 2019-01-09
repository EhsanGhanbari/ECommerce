namespace ECommerce.Services.Discounts.Messaging
{
    public class GetDiscountRequest
    {
        internal DiscountViewModel DiscountViewModel { get; private set; }

        public GetDiscountRequest(DiscountViewModel discountViewModel)
        {
            DiscountViewModel = discountViewModel;
        }
    }
}
