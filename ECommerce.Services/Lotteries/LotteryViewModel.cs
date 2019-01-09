using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Lotteries
{
    [Validator(typeof(LotteryValidation))]
    public class LotteryViewModel
    {
        public Guid LotteryId { get; set; }
    }
}
