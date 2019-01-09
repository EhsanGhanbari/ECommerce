using ECommerce.Services.Lotteries.Messaging;

namespace ECommerce.Services.Lotteries
{
    public interface ILotteryService
    {

        /// <summary>
        /// Create Lottery Service
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateLotteryResponse CreateLottery(CreateLotteryRequest request);

        /// <summary>
        /// Get Lottery Content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetLotteryResponse GetLottery(GetLotteryRequest request);


        /// <summary>
        /// Remove lottery content
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveLotteryResponse RemoveLottery(RemoveLotteryRequest request);


        /// <summary>
        /// Update Lottery
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateLotteryResponse UpdateLottery(UpdateLotteryRequest request);


        /// <summary>
        /// Get Lottery Winners
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetLotteryWinnersResponse GetLotteryWinners(GetLotteryWinnersRequest request);

    }
}
