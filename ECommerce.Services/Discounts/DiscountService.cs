using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Discounts;
using ECommerce.Services.Discounts.Messaging;

namespace ECommerce.Services.Discounts
{
    public class DiscountService : IDiscountService
    {

        private readonly IDiscountRepository _discountRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public DiscountService(IDiscountRepository discountRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _discountRepository = discountRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create spesific Discount Rule by user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateDiscountResonse CreateDiscount(CreateDiscountRequest request)
        {
            var resonse = new CreateDiscountResonse();
            var discount = request.DiscountViewModel.ConveretToDiscountModel();
            _discountRepository.Add(discount);
            _unitOfWork.Commit();
            return resonse;
        }



        /// <summary>
        /// Returns all discount
        /// discount of the system / dicount of a user 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllDiscountResponse GetAllDiscount(GetAllDiscountRequest request)
        {
            var response = new GetAllDiscountResponse();
            var discounts = _discountRepository.GetAll();
            response.DiscountViewModels = discounts.ConvertToDiscountViewModelList();
            return response;
        }


        /// <summary>
        /// Get a discount by Identity
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetDiscountResponse GetDiscount(GetDiscountRequest request)
        {
            var response = new GetDiscountResponse();
            var discount = _discountRepository.GetById(request.DiscountViewModel.DiscountId);
            response.DiscountViewModel = discount.ConvertToDiscountViewModel();
            return response;
        }


        /// <summary>
        /// Remove discount rule by 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveDiscountResponse RemoveDiscount(RemoveDiscountRequest request)
        {
            var response = new RemoveDiscountResponse();
            var discount = request.DiscountViewModel.ConveretToDiscountModel();
            _discountRepository.Remove(discount);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Update discount content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateDiscountResponse UpdateDiscount(UpdateDiscountRequest request)
        {
            var response = new UpdateDiscountResponse();
            var discount = request.DiscountViewModel.ConveretToDiscountModel();
            _discountRepository.SaveOrUpdate(discount);
            _unitOfWork.Commit();
            return response;
        }
    }
}
