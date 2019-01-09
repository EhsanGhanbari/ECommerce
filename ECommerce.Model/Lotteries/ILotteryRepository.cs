using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Lotteries
{
    public interface ILotteryRepository : IRepository<Lottery, Guid>
    {

    }
}
