using System.Collections.Generic;

namespace ECommerce.Services.Lotteries.Messaging
{
    public class GetLotteryWinnersResponse
    {
        public IEnumerable<LotteryViewModel> LotteryViewModels { get; set; } 
    }
}
