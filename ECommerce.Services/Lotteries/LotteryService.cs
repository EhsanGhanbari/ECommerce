using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Lotteries;
using ECommerce.Services.Lotteries.Messaging;

namespace ECommerce.Services.Lotteries
{
    public class LotteryService : ILotteryService
    {
        private readonly ILotteryRepository _lotteryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public LotteryService(ILotteryRepository lotteryRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _lotteryRepository = lotteryRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create Lottery Service
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateLotteryResponse CreateLottery(CreateLotteryRequest request)
        {
            var response = new CreateLotteryResponse();
            var lottery = request.LotteryViewModel.ConvertToLotteryModel();
            _lotteryRepository.Add(lottery);
            _unitOfWork.Commit();
            return response;
        }

        /// <summary>
        /// Get Lottery content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetLotteryResponse GetLottery(GetLotteryRequest request)
        {
            var response = new GetLotteryResponse();
            var lottery = _lotteryRepository.GetById(request.LotteryViewModel.LotteryId);
            response.LotteryViewModel = lottery.ConvertToLotteryViewModel();
            return response;
        }


        /// <summary>
        /// Remove a lottery 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveLotteryResponse RemoveLottery(RemoveLotteryRequest request)
        {
            var response = new RemoveLotteryResponse();
            var lottery = _lotteryRepository.GetById(request.LotteryViewModel.LotteryId);
            _lotteryRepository.Remove(lottery);
            return response;
        }

        /// <summary>
        /// Update Lottery Service
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateLotteryResponse UpdateLottery(UpdateLotteryRequest request)
        {
            var response = new UpdateLotteryResponse();
            var lottery = _lotteryRepository.GetById(request.LotteryViewModel.LotteryId);
            _lotteryRepository.SaveOrUpdate(lottery);
            return response;
        }

        /// <summary>
        /// Get Lottery Winners
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetLotteryWinnersResponse GetLotteryWinners(GetLotteryWinnersRequest request)
        {
            var response = new GetLotteryWinnersResponse();

            return response;
        }
    }
}
