using System;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Lotteries;

namespace ECommerce.Repository
{
    public class LotteryRepository : Repository<Lottery, Guid>, ILotteryRepository
    {
        public LotteryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
