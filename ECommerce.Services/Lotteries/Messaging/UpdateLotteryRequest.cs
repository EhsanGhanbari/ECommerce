namespace ECommerce.Services.Lotteries.Messaging
{
    public class UpdateLotteryRequest
    {
        internal LotteryViewModel LotteryViewModel { get; private set; }

        public UpdateLotteryRequest(LotteryViewModel lotteryViewModel)
        {
            LotteryViewModel = lotteryViewModel;
        }
    }
}
