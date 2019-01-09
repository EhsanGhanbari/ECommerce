namespace ECommerce.Services.Lotteries.Messaging
{
    public class CreateLotteryRequest
    {
        internal LotteryViewModel LotteryViewModel { get; private set; }

        public CreateLotteryRequest(LotteryViewModel lotteryViewModel)
        {
            LotteryViewModel = lotteryViewModel;
        }

    }
}
