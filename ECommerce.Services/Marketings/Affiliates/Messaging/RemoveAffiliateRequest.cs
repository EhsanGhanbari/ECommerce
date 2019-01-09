namespace ECommerce.Services.Affiliates.Messaging
{
    public class RemoveAffiliateRequest
    {
        internal AffiliateViewModel AffiliateViewModel { get; private set; }

        public RemoveAffiliateRequest(AffiliateViewModel affiliateViewModel)
        {
            AffiliateViewModel = affiliateViewModel;
        }
    }
}
