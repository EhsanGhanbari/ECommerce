namespace ECommerce.Services.Affiliates.Messaging
{
    public class CreateAffiliateRequest
    {
        internal AffiliateViewModel AffiliateViewModel { get; private set; }

        public CreateAffiliateRequest(AffiliateViewModel affiliateViewModel)
        {
            AffiliateViewModel = affiliateViewModel;
        }
    }
}
