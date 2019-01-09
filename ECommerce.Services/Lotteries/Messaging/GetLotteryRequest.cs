namespace ECommerce.Services.Lotteries.Messaging
{
    public class GetLotteryRequest
    {
        internal LotteryViewModel LotteryViewModel { get; private set; }

        public GetLotteryRequest(LotteryViewModel lotteryViewModel)
        {
            LotteryViewModel = lotteryViewModel;
        }
    }
}
