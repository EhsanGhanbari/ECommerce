namespace ECommerce.Services.Affiliates.Messaging
{
    public class GetAllAffiliatesRequest
    {
        internal AffiliateViewModel AffiliateViewModel { get; private set; }

        public GetAllAffiliatesRequest(AffiliateViewModel affiliateViewModel)
        {
            AffiliateViewModel = affiliateViewModel;
        }
    }
}
