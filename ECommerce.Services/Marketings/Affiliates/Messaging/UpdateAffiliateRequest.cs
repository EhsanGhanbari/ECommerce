namespace ECommerce.Services.Affiliates.Messaging
{
    public class UpdateAffiliateRequest
    {
        internal AffiliateViewModel AffiliateViewModel { get; private set; }

        public UpdateAffiliateRequest(AffiliateViewModel affiliateViewModel)
        {
            AffiliateViewModel = affiliateViewModel;
        }
    }
}
