namespace ECommerce.Services.Discounts.Messaging
{
    public class GetAllDiscountRequest
    {
        internal DiscountViewModel DiscountViewModel { get; private set; }

        public GetAllDiscountRequest(DiscountViewModel discountViewModel)
        {
            DiscountViewModel = discountViewModel;
        }
    }
}
