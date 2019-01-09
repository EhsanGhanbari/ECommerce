namespace ECommerce.Services.Affiliates.Messaging
{
    public class GetAffiliateRequest
    {
        internal AffiliateViewModel AffiliateViewModel { get; private set; }

        public GetAffiliateRequest(AffiliateViewModel affiliateViewModel)
        {
            AffiliateViewModel = affiliateViewModel;
        }
    }
}
