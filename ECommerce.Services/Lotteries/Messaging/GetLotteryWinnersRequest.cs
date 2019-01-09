namespace ECommerce.Services.Lotteries.Messaging
{
    public class GetLotteryWinnersRequest
    {
        internal  LotteryViewModel LotteryViewModel { get; private set; }

        public GetLotteryWinnersRequest(LotteryViewModel lotteryViewModel)
        {
            LotteryViewModel = lotteryViewModel;
        }
    }
}
