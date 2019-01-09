using ECommerce.Services.Affiliates.Messaging;

namespace ECommerce.Services.Affiliates
{
    public interface IAffiliateService
    {
        /// <summary>
        /// Create Affiliate 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateAffiliateResponse CreateAffiliate(CreateAffiliateRequest request);


        /// <summary>
        /// GetAffiliate by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAffiliateResponse GetAffiliate(GetAffiliateRequest request);

        /// <summary>
        /// Get All Affiliate 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllAffiliatesResponse GetAllAffiliates(GetAllAffiliatesRequest request);

        /// <summary>
        /// Remove Affiliate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveAffiliateResponse RemoveAffiliate(RemoveAffiliateRequest request);


        /// <summary>
        /// Update Affiliate Content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateAffiliateResponse UpdateAffiliate(UpdateAffiliateRequest request);
    }
}
