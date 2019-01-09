using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Services.Affiliates;
using ECommerce.Services.Affiliates.Messaging;

namespace ECommerce.Services.Marketings.Affiliates
{
    public class AffiliateService : IAffiliateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public AffiliateService(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Create Affiliate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateAffiliateResponse CreateAffiliate(CreateAffiliateRequest request)
        {
            var response = new CreateAffiliateResponse();
            var affiliate = request.AffiliateViewModel.ConvertToAffiliateModel();
            //_affiliateRepository.Add(affiliate);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAffiliateResponse GetAffiliate(GetAffiliateRequest request)
        {
            var response = new GetAffiliateResponse();
            //var affiliate = _affiliateRepository.Get(request.AffiliateViewModel.AffiliateId);
            //response.AffiliateViewModel = affiliate.ConvertToAffiliateViewModel();
            return response;
        }


        /// <summary>
        /// Get All Affiliate 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllAffiliatesResponse GetAllAffiliates(GetAllAffiliatesRequest request)
        {
            var response = new GetAllAffiliatesResponse();
            //var affiliates = _affiliateRepository.GetAll();
            //response.AffiliateViewModels = affiliates.ConvertToAffiliateViewModelList();
            return response;
        }


        /// <summary>
        /// Remove Affiliate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveAffiliateResponse RemoveAffiliate(RemoveAffiliateRequest request)
        {
            var response = new RemoveAffiliateResponse();
            var affiliate = request.AffiliateViewModel.ConvertToAffiliateModel();
            //_affiliateRepository.Remove(affiliate);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Update Affiliate Content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateAffiliateResponse UpdateAffiliate(UpdateAffiliateRequest request)
        {
            var response = new UpdateAffiliateResponse();
            var affiliate = request.AffiliateViewModel.ConvertToAffiliateModel();
            //_affiliateRepository.Edit(affiliate);
            _unitOfWork.Commit();
            return response;
        }
    }
}
