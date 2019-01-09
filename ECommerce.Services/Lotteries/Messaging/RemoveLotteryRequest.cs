namespace ECommerce.Services.Lotteries.Messaging
{
    public class RemoveLotteryRequest
    {
        internal LotteryViewModel LotteryViewModel { get;private set; }

        public RemoveLotteryRequest(LotteryViewModel lotteryViewModel)
        {
            LotteryViewModel = lotteryViewModel;
        }
    }
}
